using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TollClassLibrary.Helper;
using TollPlazaWebApi.Manager;
using TollPlazaWebApi.Models;
using TollPlazaWebApi.Repositories;
using TollPlazaWebApi.TollCalculaterService;
using TollClassLibrary.ViewModels;
using Microsoft.VisualBasic;

namespace TollPlazaWebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class TollController : ControllerBase
    {
        private readonly TollManager _tollManager;
        private readonly ITollEntryRepository _tollEntryRepository;
        private readonly ITollExitRepository _tollExitRepository;
        private readonly ILogger<TollController> _logger;

        public TollController(TollManager tollManager, ITollEntryRepository tollEntryRepository, ITollExitRepository tollExitRepository, ILogger<TollController> logger)
        {
            _tollManager = tollManager;
            _tollEntryRepository = tollEntryRepository;
            _tollExitRepository = tollExitRepository;
            _logger = logger;
        }

        [HttpPost("EnterToll")]
        public IActionResult EnterToll([FromBody] TollModel entry)
        {
            _logger.LogInformation("Entering toll");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_tollManager.ContainsEntryPoints(entry.InterchangeName))
                return BadRequest(new { message = "Invalid entry point." });
            var ActiveEntry = _tollEntryRepository.GetByVehicleNumber(entry.VehicleNumber);
            if (ActiveEntry != null && ActiveEntry.isActive)
                return BadRequest(new { message = "Vehicle is Already Entered From different Interchange" });

            var TollEntry = new TollEntry
            {
                VehicleNumber = entry.VehicleNumber,
                EntryPoint = entry.InterchangeName,
                EntryDate = entry.Date,
                isActive = true
            };
            try
            {
                _tollEntryRepository.Add(TollEntry);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Not able to Add Toll Entry" });
            }
            return Ok(new { message = "Entry recorded successfully", entry });
        }

        [HttpPost("ExitToll")]
        public IActionResult ExitToll([FromBody] TollModel exit)
        {
            _logger.LogInformation("Exiting toll");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entry = _tollEntryRepository.GetAll().FirstOrDefault(x => x.VehicleNumber == exit.VehicleNumber && x.isActive == true);
            if (entry == null)
                return NotFound(new { message = "Entry record not found" });
            if(!_tollManager.ContainsEntryPoints(exit.InterchangeName) || !_tollManager.ContainsEntryPoints(entry.EntryPoint))
                return BadRequest(new { message = "Invalid interchange names" });

            if (exit.Date < entry.EntryDate)
                return BadRequest(new { message = "Exit date cannot be earlier than entry date." });
            RTOExit rtoExit = new RTOExit();
            
            rtoExit.Distance = Helper.CalculateDistance(_tollManager.GetEntryPointKM( entry.EntryPoint), _tollManager.GetEntryPointKM( exit.InterchangeName));
            rtoExit.DistanceRate = _tollManager.GetRate("DistanceRate");
            ITollRate rateStrategy = null;
            if ((exit.Date.DayOfWeek == DayOfWeek.Saturday || exit.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                rateStrategy = new WeekendTollRate(_tollManager);
                rtoExit.WeekendRate = _tollManager.GetRate("WeekendRate");
            }
            else
            {
                rateStrategy = new NormalTollRate(_tollManager);
            }
            rtoExit.DistanceCost = rateStrategy.CalculateToll(rtoExit.Distance);
            rtoExit.BaseRate = _tollManager.GetRate(StringConstants.BaseRate);
            rtoExit.TotalCost = rtoExit.DistanceCost;
            var nationalHolidays = _tollManager.GetSpecialDiscountDays().Select(month_day => new DateTime(exit.Date.Year, month_day / 100, month_day % 100));
            if (nationalHolidays.Contains(exit.Date))
            {
                rtoExit.DiscountRate = _tollManager.GetRate(StringConstants.NationHolidayDiscountRate);
            }
            else if ((entry.EntryDate.DayOfWeek == DayOfWeek.Monday || entry.EntryDate.DayOfWeek == DayOfWeek.Wednesday) && Helper.isEvenNumberPlate(entry.VehicleNumber))
            {
                rtoExit.DiscountRate = _tollManager.GetRate(StringConstants.NumberPlateDiscountRate);
            }
            else if ((entry.EntryDate.DayOfWeek == DayOfWeek.Tuesday || entry.EntryDate.DayOfWeek == DayOfWeek.Thursday) && !Helper.isEvenNumberPlate(entry.VehicleNumber))
            {
                rtoExit.DiscountRate = _tollManager.GetRate(StringConstants.NumberPlateDiscountRate);
            }
            rtoExit.TotalCost *= (1 - rtoExit.DiscountRate);
            rtoExit.TotalCost += rtoExit.BaseRate;
            try
            {
                var NewExit = new TollExit
                {
                    EntryId = entry.Id,
                    ExitDate = exit.Date,
                    DistanceTraveled = rtoExit.Distance,
                    TollAmount = rtoExit.TotalCost,
                    ExitPoint = exit.InterchangeName
                };
                entry.isActive = false;
                _tollExitRepository.AddExit(NewExit, entry);

                return Ok(rtoExit);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Not able to Add Toll Exit" });
            }
        }
    }
}

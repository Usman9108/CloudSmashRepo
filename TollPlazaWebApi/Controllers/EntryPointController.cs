using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TollPlazaWebApi.Models;
using TollPlazaWebApi.Repositories;
using TollClassLibrary.ViewModels;

namespace TollPlazaWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryPointController : ControllerBase
    {
        private readonly ILogger<EntryPointController> _logger;
        private readonly IRepository<EntryPoint> _repository;

        public EntryPointController(ILogger<EntryPointController> logger, IRepository<EntryPoint> repository)
        {
            _logger = logger;
            _repository = repository;
        }
        [HttpGet("GetEntryPoints")]
        public IActionResult GetEntryPoints()
        {

            _logger.LogInformation("Getting all entry points");
            try
            {
                return Ok(_repository.GetAll().Select(x => x.PointName));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting entry points");
                return StatusCode(500, new { message = "Error getting entry points" });
            }
        }
        [HttpPost("AddEntryPoints")]
        public IActionResult AddEntryPoints([FromBody] EntryPointModel entryPointModel)
        {
            _logger.LogInformation("Adding entry point");
            if (!ModelState.IsValid)
            {
                _logger.LogError($"{entryPointModel.Name} Invalid Entry Point ");
                return BadRequest(new { message = "Invalid Entry Point" });
            }


            var entryPoint = new EntryPoint
            {
                PointName = entryPointModel.Name,
                KMFromZeroPoint = entryPointModel.KMFromZeroPoint
            };
            try
            {
                _repository.Add(entryPoint);
                _logger.LogInformation($"Adding Entry Point {entryPointModel.Name}");
                return Ok(new { message = "Entry recorded successfully", entryPoint });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding entry point");
                return StatusCode(500, new { message = "Error adding entry point" });

            }
        }
    }
}

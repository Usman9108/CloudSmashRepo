using TollPlazaWebApi.Models;
using TollPlazaWebApi.Repositories;

namespace TollPlazaWebApi.Manager
{
    public class TollManager
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly object _locker = new object();

        private Dictionary<string, double> rates = new Dictionary<string, double>();
        private List<int> specialDiscountDays = new List<int>();
        private Dictionary<string, int> entryPoints = new Dictionary<string, int>();

        private bool isRatesDirty = true;
        private bool isSpecialDiscountDayDirty = true;
        private bool isEntryPointsDirty = true;

        public TollManager(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
            LoadData();
        }

        private void LoadData()
        {
            lock (_locker)
            {
                if (isRatesDirty)
                {
                    GetAllRates();
                    isRatesDirty = false;
                }

                if (isSpecialDiscountDayDirty)
                {
                    GetSpecialDiscountDays();
                    isSpecialDiscountDayDirty = false;
                }

                if (isEntryPointsDirty)
                {
                    GetEntryPoints();
                    isEntryPointsDirty = false;
                }
            }
        }

        public void SetDirty(string className)
        {
            lock (_locker)
            {
                if (className == nameof(TollRate))
                    isRatesDirty = true;
                else if (className == nameof(SpecialDiscountDay))
                    isSpecialDiscountDayDirty = true;
                else if (className == nameof(EntryPoint))
                    isEntryPointsDirty = true;
            }
        }

        public bool ContainsEntryPoints(string name)
        {
            lock (_locker)
            {
                if (entryPoints.Count == 0 || isEntryPointsDirty)
                {
                    GetEntryPoints();
                    isEntryPointsDirty = false;
                }
                return entryPoints.ContainsKey(name);
            }
        }

        private void GetAllRates()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var scopedService = scope.ServiceProvider.GetRequiredService<IRepository<TollRate>>();
                lock (_locker)
                {
                    rates = scopedService.GetAll().ToDictionary(rate => rate.Name, rate => rate.Rate);
                }
            }
        }

        private void GetEntryPoints()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var scopedService = scope.ServiceProvider.GetRequiredService<IRepository<EntryPoint>>();
                lock (_locker)
                {
                    entryPoints = scopedService.GetAll().ToDictionary(ep => ep.PointName, ep => ep.KMFromZeroPoint);
                }
            }
        }

        public IEnumerable<int> GetSpecialDiscountDays()
        {
            lock (_locker)
            {
                if (specialDiscountDays.Count == 0 || isSpecialDiscountDayDirty)
                {
                    using (var scope = _serviceScopeFactory.CreateScope())
                    {
                        var scopedService = scope.ServiceProvider.GetRequiredService<IRepository<SpecialDiscountDay>>();
                        specialDiscountDays = scopedService.GetAll().Select(sdd => sdd.Month_Day).ToList();
                    }
                    isSpecialDiscountDayDirty = false;
                }
                return specialDiscountDays;
            }
        }

        public int GetEntryPointKM(string name)
        {
            lock (_locker)
            {
                if (entryPoints.Count == 0 || isEntryPointsDirty)
                {
                    GetEntryPoints();
                    isEntryPointsDirty = false;
                }
                return entryPoints.TryGetValue(name, out var km) ? km : 0;
            }
        }

        public double GetRate(string name)
        {
            lock (_locker)
            {
                if (rates.Count == 0 || isRatesDirty)
                {
                    GetAllRates();
                    isRatesDirty = false;
                }
                return rates.TryGetValue(name, out var rate) ? rate : 0;
            }
        }
    }
}
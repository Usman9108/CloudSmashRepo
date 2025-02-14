using TollClassLibrary.Helper;
using TollPlazaWebApi.Manager;

namespace TollPlazaWebApi.TollCalculaterService
{
    public class WeekendTollRate : ITollRate
    {
        private readonly TollManager _tollManager;
        public WeekendTollRate(TollManager tollManager)
        {
            _tollManager = tollManager;
        }

        public TollManager TollManager => _tollManager;

        public double CalculateToll(int distance)
        {
            return distance * TollManager.GetRate(StringConstants.DistanceRate) * TollManager.GetRate(StringConstants.WeekendRate);
        }
    }
}

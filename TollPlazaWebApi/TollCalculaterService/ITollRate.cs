using TollPlazaWebApi.Manager;

namespace TollPlazaWebApi.TollCalculaterService
{
    public interface ITollRate
    {
        TollManager TollManager { get; }
        double CalculateToll(int distance);
    }
}

using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Repositories
{
    public interface ITollEntryRepository
    {
        IEnumerable<TollEntry> GetAll();
        TollEntry? Get(int id);
        TollEntry? GetByVehicleNumber(string vehicleNumber);
        void Add(TollEntry entity);
        void Update(TollEntry entity);
        void Delete(int id);
    }
}

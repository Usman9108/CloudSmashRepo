using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Repositories
{
    public interface ITollExitRepository
    {
        void AddExit(TollExit tollExit, TollEntry tollEntry);
    }
}

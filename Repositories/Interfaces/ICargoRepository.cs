using SoftUniSpaceConsoleWebApp.Data.Entities;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ICargoRepository
    {
        void Add(Cargo cargo);

        IEnumerable<Cargo> GetAll();
    }
}

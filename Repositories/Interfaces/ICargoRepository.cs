using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Cargo;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ICargoRepository
    {
        void Add(Cargo crew);

        IEnumerable<Cargo> GetAll(); //138

       
        void Delete(int id);

        CargoViewModel Get(int id);
    }
}

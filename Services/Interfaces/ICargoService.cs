using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.Cargo;



namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface ICargoService
    {
        void Add(CreateCargoViewModel cargo);

        IEnumerable<CargoViewModel> GetAll();

        void Delete(int id);

        CargoViewModel Get(int id);
    }
}
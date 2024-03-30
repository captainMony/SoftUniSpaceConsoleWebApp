using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.Crew;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface ICargoService
    {
        void Add(CreateCargoViewModel cargo);

        IEnumerable<CargoViewModel> GetAll();
    }
}

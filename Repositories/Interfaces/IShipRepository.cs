using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Ship;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface IShipRepository
    {
        void Add(Ship ship);

        IEnumerable<Ship> GetAll();

        void Delete(int id);

        ShipViewModel Get(int id);

    }
}

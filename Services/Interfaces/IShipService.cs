
using SoftUniSpaceConsoleWebApp.Models.Ship;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface IShipService
    {


        void Add(CreateShipViewModel Ship);

        IEnumerable<ShipViewModel> GetAll();

        void Delete(int id);

        ShipViewModel Get(int id);

    }
}

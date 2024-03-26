
using SoftUniSpaceConsoleWebApp.Models.Ship;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface IShipService
    {


        void Add(CreateShipViewModel crewMember);

        IEnumerable<ShipViewModel> GetAll();

    }
}

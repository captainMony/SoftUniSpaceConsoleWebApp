using SoftUniSpaceConsoleWebApp.Data.Entities;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface IShipRepository
    {
        void Add(Ship ship);



        IEnumerable<Ship> GetAll();



    }
}

using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Ship;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class ShipRepository : IShipRepository
    {



        private readonly ApplicationContext context; //Context comes from here !!!

        public ShipRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void Add(Ship ship)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ShipViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ship> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

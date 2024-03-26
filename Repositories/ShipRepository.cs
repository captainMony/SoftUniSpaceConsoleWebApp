using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;
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

        public IEnumerable<Ship> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

using SoftUniSpaceConsoleWebApp.Models.Ship;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class ShipService : IShipService
    {
        private readonly IShipRepository shipRepository;


        public ShipService(IShipRepository shipRepository) //Constructor we use to Dependency inject??
        {
            this.shipRepository = shipRepository;   

        } 
        public void Add(CreateShipViewModel Ship)
        {
            
        }
       
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ShipViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShipViewModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Ship;
using SoftUniSpaceConsoleWebApp.Repositories;
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
          
            var ShipEntity = new Ship(Ship.ShipName, Ship.ShipAge);
            shipRepository.Add(ShipEntity);
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

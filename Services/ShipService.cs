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
          
            var ShipEntity = new Ship(Ship.ShipName, Ship.ShipAge,Ship.UniverseGroup);
            shipRepository.Add(ShipEntity);
        }
       
        public void Delete(int id)
        => shipRepository.Delete(id); 

        public ShipViewModel Get(int id)
        {
            var shipid = shipRepository.Get(id);

            return new ShipViewModel(shipid); //QUICK FIX THIS
        }

        public IEnumerable<ShipViewModel> GetAll()
        {
            var ShipEntities = shipRepository.GetAll();

            var ships = ShipEntities.Select(Ship => new ShipViewModel(Ship.ShipId,Ship.ShipName,Ship.ShipAge,Ship.UniverseGroup));

            return ships;
        }
    }
}

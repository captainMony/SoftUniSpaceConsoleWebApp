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
           
            context.Ship.Add(ship);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            var shipid = Get(id);       
            context.Ship.Remove(shipid);
            context.SaveChanges();
        }
                 
        public Ship Get(int id)
        => context.Ship.FirstOrDefault(ShipsID => ShipsID.ShipId == id);

        public IEnumerable<Ship> GetAll()     
        => context.Ship.ToList();

        ShipViewModel IShipRepository.Get(int id) //QUICK FIX IF INTERFACE WANTS GET METHOD LEAVE AS IS 
        {
            throw new NotImplementedException();
        }
    }
}

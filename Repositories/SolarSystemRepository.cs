using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;

using SoftUniSpaceConsoleWebApp.Models.SolarSystem;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class SolarSystemRepository : ISolarSystemRepository
    {
        private readonly ApplicationContext context;

        public SolarSystemRepository(ApplicationContext context)
        {
            this.context = context;
        }


        public void Add(Data.Entities.SolarSystem system)
        {
            context.SolarSystem.Add(system);
            context.SaveChanges();
        }

        public void Delete(int id)
        {

            var solarsystemid = Get(id);
            context.SolarSystem.Remove(solarsystemid);
            context.SaveChanges();
        }

        public Data.Entities.SolarSystem Get(int id) 
         => context.SolarSystem.FirstOrDefault(ShipsID => ShipsID.Id == id);

        public IEnumerable<Data.Entities.SolarSystem> GetAll()
        => context.SolarSystem.ToList();

        
    }
}

using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Planet;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class PlanetRepo : IPlanetRepo
    {
        private readonly ApplicationContext context; //Context comes from here !!!

        public PlanetRepo(ApplicationContext context)
        {
            this.context = context;
        }
        public void Add(Planet Planet)
        {
            context.Planet.Add(Planet);
            context.SaveChanges(); //Not working
        }

        public IEnumerable<Planet> GetAll()
        => context.Planet.ToList();

        public void Delete(int id)
        {
            var Planet = Get(id);
            context.Planet.Remove(Planet);
            context.SaveChanges();

        }

        public Planet Get(int id)
           => context.Planet.FirstOrDefault(PlanetID => PlanetID.Id == id);

        PlanetViewModel IPlanetRepo.Get(int id) //IMPLEMENTED
        {
            throw new NotImplementedException();
        }
    }
}
    

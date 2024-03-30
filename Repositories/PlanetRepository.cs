using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly ApplicationContext context;

        public PlanetRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void Add(Panet Planet)
        {
            context.Planets.Add(Planet);
            context.SaveChanges();
        }

        public IEnumerable<Planet> GetAll()
        => context.Planets.ToList();

    }
}

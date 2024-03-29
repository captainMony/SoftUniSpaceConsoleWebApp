using SoftUniSpaceConsoleWebApp.Services.Interfaces;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Planet;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class PlanetServices : IPlanetService
    {

        private readonly IPlanetRepo planetReposiotry;

        public PlanetServices (IPlanetRepo planetReposiotry)
        {
            this.planetReposiotry = planetReposiotry;
        }

        public void Add(CreatePlanetViewModel Planet)
        {
            var PlanetEntity = new Planet(Planet.Name, Planet.UniverseGroup);
            planetReposiotry.Add(PlanetEntity);
        }
       
        public IEnumerable<PlanetViewModel> GetAll()
        {
            var PlanetEntities = planetReposiotry.GetAll();

            var planets = PlanetEntities.Select(Planet => new PlanetViewModel(Planet.Id, Planet.Name, Planet.UniverseGroup));

            return planets;
        }

        public void Delete(int id)
            => planetReposiotry.Delete(id);

        public PlanetViewModel Get(int id)
        {
                var planetid = planetReposiotry.Get(id);
            return new PlanetViewModel(planetid);
        }
 
    }
}

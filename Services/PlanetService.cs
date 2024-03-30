using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            this.planetRepository = planetRepository;
        }

        public void Add(CreatePlanetViewModel Planet)
        {
            var PlanetEntity = new Planet(Planet.Name, Planet.Type);

            planetRepository.Add(PlanetEntity);
        }

        public IEnumerable<PlanetViewModel> GetAll()
        {
            var PlanetEntities = planetRepository.GetAll();

            var planets = PlanetEntities.Select(Planet => new PlanetViewModel(Planet.Id, Planet.Name, Planet.Type));

            return planets;
        }
    }
}

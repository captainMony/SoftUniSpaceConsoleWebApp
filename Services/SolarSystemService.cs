
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.SolarSystem;
using SoftUniSpaceConsoleWebApp.Repositories;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class SolarSystemService : ISolarSystemService
    {

        private readonly ISolarSystemRepository solarSystemRepository;

        public SolarSystemService(ISolarSystemRepository solarsystemRepository) //Constructor we use to Dependency inject??
        {
            this.solarSystemRepository = solarsystemRepository;

        }

        void ISolarSystemService.Add(CreateSolarSystemViewModel System)

        {
           // try to fix if not redo the table 

        }

        public void Delete(int id)
              => solarSystemRepository.Delete(id);


        public SolarSystemViewModel Get(int id)
        {
            var systemid = solarSystemRepository.Get(id);
            
            return new SolarSystemViewModel(systemid); //DOESNT WORK TO DO
        }

     
        public IEnumerable<SolarSystemViewModel> GetAll()
        {
            var systemEntities = solarSystemRepository.GetAll();
            var systems = systemEntities.Select(system => new SolarSystemViewModel(system.Id, system.Name, system.UniverseGroup));
            return systems;
        }
     
    }
}

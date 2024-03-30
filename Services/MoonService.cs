using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Moon;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class MoonService : IMoonService

    {
        private readonly IMoonRepository moonRepository;

        public MoonService(IMoonRepository moonRepository)
        {
            this.moonRepository = moonRepository;
        }     

        public void Add(CreateMoonViewModel Moon)
        {
            var MoonEntity = new Moon(Moon.Name, Moon.Size, Moon.UniverseGroup);
            moonRepository.Add(MoonEntity);
            
        }
        public IEnumerable<MoonViewModel> GetAll()
        {
            var MoonEntities = moonRepository.GetAll();

            var moons = MoonEntities.Select(Moon => new MoonViewModel(Moon.Id, Moon.Size, Moon.UniverseGroup));
           
            return moons;
        }
        public void Delete(int id) 
            => moonRepository.Delete(id);

            public MoonViewModel Get(int id)
            {
                var moonid = moonRepository.Get(id);

                return new MoonViewModel(moonid);

            }
                      
    }
}

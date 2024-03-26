using MySqlX.XDevAPI.CRUD;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class CrewService : ICrewService
    {
        private readonly ICrewRepository crewRepository;
       

        public CrewService(ICrewRepository crewRepository) {

            this.crewRepository = crewRepository;
        
        
        }
        public void Add(CreateCrewViewModel Crew)
        {
            var CrewEntity = new Crew(Crew.Name, Crew.Age, Crew.Rank);

            crewRepository.Add(CrewEntity);

          
        }
        public IEnumerable<CrewViewModel> GetAll()
        {
            var CrewEntities = crewRepository.GetAll();

            var crews = CrewEntities.Select(Crew => new CrewViewModel(Crew.Id,Crew.Name,Crew.Age,Crew.Rank));

            return crews;
        }

        public void Delete(int id) => crewRepository.Delete(id); //Step 2 call Repository Delete Method 



    }
}

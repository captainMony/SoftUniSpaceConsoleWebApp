using MySqlX.XDevAPI.CRUD;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models;
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
        public void Add(CreateCrewViewModel CrewModel)
        {
            var CrewEntity = new Crew(CrewModel.Name, CrewModel.Age, CrewModel.Rank);

            crewRepository.Add(CrewEntity);

          
        }
    }
}

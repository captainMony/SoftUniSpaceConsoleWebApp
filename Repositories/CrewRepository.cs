using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class CrewRepository : ICrewRepository
    {
        private readonly ApplicationContext context;

        public CrewRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void Add(Crew crew)
        {
            context.Crewmen.Add(crew);  
            context.SaveChanges();  

        }
    }
}

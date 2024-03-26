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
        public void Add(Crew Crew)
        {
            context.Crewmen.Add(Crew);  
            context.SaveChanges();  
        }
       
        public IEnumerable<Crew> GetAll() //Context???
        => context.Crewmen.ToList();    //Crewmen ot DB SET!!!???

        public void Delete(int Id) //12:39 Last 25/03
       

    }
}

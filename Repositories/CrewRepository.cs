using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class CrewRepository : ICrewRepository
    {
        private readonly ApplicationContext context; //Context comes from here !!!

        public CrewRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void Add(Crew Crew)
        {
            context.Crewmen.Add(Crew);  
            context.SaveChanges();  
        }
       
        public IEnumerable<Crew> GetAll() //Context??? oh... 
        => context.Crewmen.ToList();    //Crewmen ot DB SET!!!???

        public void Delete(int id)
        {
            var crewmemberid = Get(id);       //UNABLE to Get(id)?? Get does not exist ??
                context.Crewmen.Remove(crewmemberid);
                context.SaveChanges() ;

        }

        public Crew Get(int id) //
           => context.Crewmen.FirstOrDefault(CrewmansID => CrewmansID.Id == id); //Hover over FirstOrDefault for explanation duh

        CrewViewModel ICrewRepository.Get(int id) //it works like this??? Catch 22
        {
            throw new NotImplementedException();
        }
    }
}

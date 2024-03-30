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
            context.SaveChanges();  //if this doesnt wrok i messed up migrations 
        }
       
        public IEnumerable<Crew> GetAll() //Context??? oh... 
        => context.Crewmen.ToList();    //Crewmen ot DB SET!!!???

        public void Delete(int id)
        {
            var crewmemberid = Get(id);       //UNABLE to Get(id)?? Get does not exist ?? Needed Get method to GET THE ID 
                context.Crewmen.Remove(crewmemberid);
                context.SaveChanges() ;

        }

        public Crew Get(int id) //The get i made and use
           => context.Crewmen.FirstOrDefault(CrewmansID => CrewmansID.Id == id); 

        CrewViewModel ICrewRepository.Get(int id) //The get the interface wants??
        {
            throw new NotImplementedException();
        }
    }
}

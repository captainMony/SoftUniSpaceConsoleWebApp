using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Moon;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class MoonRepository : IMoonRepository
    {
        private readonly ApplicationContext context;

        public MoonRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void Add(Moon Moon)
        {
            context.Moon.Add(Moon);
            context.SaveChanges();
        }
        public IEnumerable<Moon> GetAll() 
            => context.Moon.ToList();  

        public void Delete(int id)
        {
            var moonid = Get(id);
            context.Moon.Remove(moonid);
            context.SaveChanges();

        }

        public Moon Get(int id)
            => context.Moon.FirstOrDefault(MoonId => MoonId.Id == id);
   
    
    
    }


}

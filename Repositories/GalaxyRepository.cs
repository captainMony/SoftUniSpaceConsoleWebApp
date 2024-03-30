using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Models.Galaxy;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class GalaxyRepository : IGalaxyReposiotry
    {
        private readonly ApplicationContext context;

        public GalaxyRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void Add(Galaxy galaxy)
        {
            context.Galaxy.Add(galaxy);
            context.SaveChanges(); //IF THIS DOESNT WORK MIGRATION???

        }
        public IEnumerable<Galaxy> GetAll()
            => context.Galaxy.ToList();

        public void Delete(int Id)
        {
            var galaxyid = Get(Id);
            context.Galaxy.Remove(galaxyid);
            context.SaveChanges();

        }
        public Galaxy Get(int id) => context.Galaxy.FirstOrDefault(GalaxyID => GalaxyID.Id == id);

        GalaxyViewModel IGalaxyReposiotry.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}

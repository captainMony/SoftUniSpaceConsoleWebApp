using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Galaxy;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface IGalaxyReposiotry
    {

        void Add(Galaxy galaxy);

        IEnumerable<Galaxy> GetAll();

        void Delete(int Id); // must be as defined

        GalaxyViewModel Get(int id);



    }
}

using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Models.SolarSytem;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ISolarSystemRepository
    {

        void Add(Crew crew);

        IEnumerable<SolarSystem> GetAll();

        // void Delete(Crew crew);
        void Delete(int id);

         SolarSystemViewModel Get(int id);


    }
}

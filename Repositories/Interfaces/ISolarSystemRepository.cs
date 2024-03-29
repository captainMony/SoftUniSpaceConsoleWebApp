using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.SolarSystem;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ISolarSystemRepository
    {
        void Add(SolarSystem system);

        IEnumerable<SolarSystem> GetAll();

        void Delete(int id);

         SolarSystemViewModel Get(int id);


    }
}

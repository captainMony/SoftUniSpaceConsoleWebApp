using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.SolarSystem;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ISolarSystemRepository
    {


        void Add(SolarSystem spaceStation);

        IEnumerable<SolarSystem> GetAll();

        void Delete(int id);

        SolarSystem Get(int id);



    }
}

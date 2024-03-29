using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Planet;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface IPlanetRepo
    {
        void Add(Planet planet);

        IEnumerable<Planet> GetAll(); 
 
        void Delete(int id);

        PlanetViewModel Get(int id);


    }
}

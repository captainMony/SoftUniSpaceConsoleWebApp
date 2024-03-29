using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Planet;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface IPlanetService
    {
        void Add(CreatePlanetViewModel planet);

        IEnumerable<PlanetViewModel> GetAll(); //138

        void Delete(int id);

        PlanetViewModel Get(int id);



    }
}

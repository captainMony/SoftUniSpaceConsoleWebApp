using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Models;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface IPlanetService
    {
        void Add(CreatePlanetViewModel planet);

        IEnumerable<PlanetViewModel> GetAll();
    }
}

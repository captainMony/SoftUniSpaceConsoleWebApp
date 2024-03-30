using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.SpaceStation;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface ISpaceStationService
    {
        void Add(CreateSpaceStationViewModel spaceStation);

        IEnumerable<SpaceStationViewModel> GetAll();
    }
}

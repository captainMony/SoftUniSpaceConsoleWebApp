using SoftUniSpaceConsoleWebApp.Models.SpaceStation;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface ISpaceStationService
    {
        void Add(CreateSpaceStationViewModel galaxy);

        IEnumerable<SpaceStationViewModel> GetAll();

        void Delete(int id);
        SpaceStationViewModel Get(int id);


    }
}

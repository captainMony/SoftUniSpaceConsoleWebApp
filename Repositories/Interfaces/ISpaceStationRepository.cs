using SoftUniSpaceConsoleWebApp.Data.Entities;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ISpaceStationRepository
    {
        void Add(SpaceStation spaceStation);

        IEnumerable<SpaceStation> GetAll();
    }
}

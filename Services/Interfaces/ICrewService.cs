using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Crew;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface ICrewService
    {
        void Add(CreateCrewViewModel crewMember);

        IEnumerable<CrewViewModel> GetAll();

        void Delete(int id);

        CrewViewModel Get(int id);

    }
}

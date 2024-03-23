using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.Crew;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface ICrewService
    {
        void Add(CreateCrewViewModel crewMember);

        IEnumerable<CrewViewModel> GetAll();




       /// public void Add()
       // {
       // }

    }
}

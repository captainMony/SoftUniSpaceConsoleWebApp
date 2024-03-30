using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Galaxy;
namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface IGalaxyService
    {
        void Add(CreateGalaxyViewModel galaxy);

        IEnumerable<GalaxyViewModel> GetAll();

        void Delete(int id);
        GalaxyViewModel Get(int id);
        // void Add(CreateCrewViewModel crewMember);

       //Enumerable<CrewViewModel> GetAll();
       //
       //oid Delete(int id);
       //
       //rewViewModel Get(int id);
       
        
    }
}

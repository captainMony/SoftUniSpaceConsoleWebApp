using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Crew;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface ICrewRepository
    {
        void Add(Crew crew);

        IEnumerable<Crew> GetAll(); //138

       // void Delete(Crew crew);
        void Delete(int id);

        CrewViewModel Get(int id);
    }
}

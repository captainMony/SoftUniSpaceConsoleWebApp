using SoftUniSpaceConsoleWebApp.Data.Entities;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface IPlanetRepository
    {
        void Add(Planet planet);

        IEnumerable<Panet> GetAll();
    }
}

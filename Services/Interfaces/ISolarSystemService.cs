using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.SolarSystem;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface ISolarSystemService
    {

        void Add(CreateSolarSystemViewModel SolarSystem);

        IEnumerable<SolarSystemViewModel> GetAll();

        void Delete(int id);

        SolarSystemViewModel Get(int id);



    }
}

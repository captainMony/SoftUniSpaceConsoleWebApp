using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Models.SolarSytem;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class SolarSystemService : ISolarSystemService
    {
        void ISolarSystemService.Add(CreateSolarSystemViewModel SolarSystem)
        {
            throw new NotImplementedException();
        }

        void ISolarSystemService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        SolarSystemViewModel ISolarSystemService.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<SolarSystemViewModel> ISolarSystemService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

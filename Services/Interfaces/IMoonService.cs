using SoftUniSpaceConsoleWebApp.Models.Moon;

namespace SoftUniSpaceConsoleWebApp.Services.Interfaces
{
    public interface IMoonService
    {
        void Add(CreateMoonViewModel Moon);

        IEnumerable<MoonViewModel> GetAll();

        void Delete(int id);
        MoonViewModel Get(int id);        
    }
}

using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Moon;
using SoftUniSpaceConsoleWebApp.Services;

namespace SoftUniSpaceConsoleWebApp.Repositories.Interfaces
{
    public interface IMoonRepository
    {
        void Add(Moon moon);

        IEnumerable<Moon> GetAll();

        void Delete(int Id); 

        Moon Get(int id);

       
    }
}

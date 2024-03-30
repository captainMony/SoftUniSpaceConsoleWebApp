using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly ApplicationContext context;

        public CargoRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void Add(Cargo Cargo)
        {
            context.Cargo.Add(Cargo);
            context.SaveChanges();
        }

        public IEnumerable<Cargo> GetAll()
        => context.Cargo.ToList();
    }
}

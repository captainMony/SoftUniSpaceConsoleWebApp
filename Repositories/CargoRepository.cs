using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using System.Net.Http.Headers;
using SoftUniSpaceConsoleWebApp.Models.Cargo;

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

        public void Delete(int id)
        {
            var Ci = Get(id);       //UNABLE to Get(id)?? Get does not exist ?? Needed Get method to GET THE ID 
            context.Cargo.Remove(Ci);
            context.SaveChanges();

        }

        public Cargo Get(int id) //The get i made and use
           => context.Cargo.FirstOrDefault(GID => GID.Id == id);

        CargoViewModel ICargoRepository.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
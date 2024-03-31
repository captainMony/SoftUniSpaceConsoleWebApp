using MySqlX.XDevAPI.CRUD;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Models.Cargo;
using SoftUniSpaceConsoleWebApp.Repositories;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository cargoRepository;

        public CargoService(ICargoRepository cargoRepository)
        {
            this.cargoRepository = cargoRepository;
        }

        public void Add(CreateCargoViewModel Cargo)
        {
            var CargoEntity = new Cargo(Cargo.Type, Cargo.Name, Cargo.Quantity,Cargo.UniverseGroup);

            cargoRepository.Add(CargoEntity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CargoViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CargoViewModel> GetAll()
        {
            var CargoEntities = cargoRepository.GetAll();

            var cargos = CargoEntities.Select(Cargo => new CargoViewModel(Cargo.Id, Cargo.Type, Cargo.Name, Cargo.Quantity, Cargo.UniverseGroup));

            return cargos;
        }
    }
}
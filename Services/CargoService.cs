using MySqlX.XDevAPI.CRUD;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.Cargo;
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
            var CargoEntity = new Cargo(Cargo.Type, Cargo.Name, Cargo.Quantity);

            crewRepository.Add(CrewEntity);
        }

        public IEnumerable<CargoViewModel> GetAll()
        {
            var CargoEntities = cargoRepository.GetAll();

            var cargos = CargoEntities.Select(Cargo => new CargoViewModel(Cargo.Id, Cargo.Type, Cargo.Name, Cargo.Quantity));

            return cargos;
        }
    }
}

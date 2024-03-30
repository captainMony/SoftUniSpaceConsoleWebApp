using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Models.SpaceStation;
using SoftUniSpaceConsoleWebApp.Repositories;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class SpaceStationService : ISpaceStationService
    {
        private readonly ISpaceStationRepository spaceStationRepository;
public SpaceStationService(ISpaceStationRepository spaceStationRepository)
        {
            this.spaceStationRepository = spaceStationRepository;
        }

        public void Add(CreateSpaceStationViewModel station)
        {
            var StationEntity = new SpaceStation(station.Name, station.UniverseGroup);
            spaceStationRepository.Add(StationEntity);
        }

        public IEnumerable<SpaceStationViewModel> GetAll()
        {
            var SpaceStationEntities = spaceStationRepository.GetAll();

            var stations = SpaceStationEntities.Select(Station => new SpaceStationViewModel(Station.Id, Station.Name, Station.UniverseGroup));

            return stations;
        }

        public void Delete(int id)
              => spaceStationRepository.Delete(id);

        public SpaceStationViewModel Get(int id)
        {
            var stationId = spaceStationRepository.Get(id);
            return new SpaceStationViewModel(stationId); //TO DO
        }



    }
}

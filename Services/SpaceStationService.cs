using SoftUniSpaceConsoleWebApp.Models.Crew;
using SoftUniSpaceConsoleWebApp.Models;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using MySqlX.XDevAPI.CRUD;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Models.SpaceStation;
using SoftUniSpaceConsoleWebApp.Data.Entities;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Services
{
    public class SpaceStationService : ISpaceStationService
    {
        private readonly ISpaceStationRepository crewRepository;

        public SpaceStationService(ISpaceStationRepository spaceStationRepository)
        {
            this.spaceStationRepository = spaceStationRepository;
        }

        public void Add(CreateSpaceStationViewModel SpaceStation)
        {
            var SpaceStationEntity = new SpaceStation(SpaceStation.Name);

            spaceStationRepository.Add(SpaceStationEntity);
        }

        public IEnumerable<SpaceStationViewModel> GetAll()
        {
            var SpaceStationEntities = spaceStationRepository.GetAll();

            var spaceStations = SpaceStationEntities.Select(SpaceStation => new SpaceStationViewModel(SpaceStation.Name));

            return spaceStations;
        }
    }
}

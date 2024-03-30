using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using System.Net.Http.Headers;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class SpaceStationRepository : ISpaceStationRepository
    {
        private readonly ApplicationContext context;

        public SpaceStationRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void Add(SpaceStation SpaceStation)
        {
            context.SpaceStations.Add(SpaceStation);
            context.SaveChanges();
        }

        public IEnumerable<SpaceStation> GetAll()
        => context.SpaceStations.ToList();
    }
}

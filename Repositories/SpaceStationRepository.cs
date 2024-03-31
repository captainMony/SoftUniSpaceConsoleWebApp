using SoftUniSpaceConsoleWebApp.Data.Entities;
using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Models.SpaceStation;

namespace SoftUniSpaceConsoleWebApp.Repositories
{
    public class SpaceStationRepository : ISpaceStationRepository
    {
        private readonly ApplicationContext context;
        public SpaceStationRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void Add(SpaceStation spacestation)
        {
            context.SpaceStation.Add(spacestation);
            context.SaveChanges();
        }

        public IEnumerable<SpaceStation> GetAll()
            => context.SpaceStation.ToList();

        public void Delete(int id)
        {
            var stationid = Get(id);
            context.SpaceStation.Remove(stationid); 
            context.SaveChanges();
        }

        public SpaceStation Get(int id)
            => context.SpaceStation.FirstOrDefault(stationID => stationID.Id == id);


    }
}

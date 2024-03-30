

namespace SoftUniSpaceConsoleWebApp.Models.SpaceStation
{
    public class SpaceStationViewModel
    {
        public SpaceStationViewModel(Data.Entities.SpaceStation stationId)
        {
        }

        public SpaceStationViewModel(int id, string name, string universeGroup)
        {
            Id = id;
            Name = name;
            UniverseGroup = universeGroup;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string UniverseGroup { get; set; }


    }
}

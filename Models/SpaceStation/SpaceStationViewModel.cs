namespace SoftUniSpaceConsoleWebApp.Models.SpaceStation
{
    public class SpaceStationViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UniverseGroup { get; set; }

        public SpaceStationViewModel(int id, string type, string name, double quantity)
        {
            Id = id;
            Name = name;
            UniverseGroup = universeGroup;
        }
    }
}

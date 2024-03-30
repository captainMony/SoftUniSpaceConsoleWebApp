namespace SoftUniSpaceConsoleWebApp.Models.Planet
{
    public class PlanetViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string UniverseGroup { get; set; }

        public CrewViewModel(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
            UniverseGroup = universeGroup;
        }
    }
}

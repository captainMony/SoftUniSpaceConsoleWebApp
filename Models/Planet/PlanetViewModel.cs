namespace SoftUniSpaceConsoleWebApp.Models.Planet
{
    public class PlanetViewModel
    {
        public int Id { get; set; } // bruh
        public string Name { get; set; }
        public string UniverseGroup { get; set; }

        public PlanetViewModel(int id, string name, string universeGroup)
        {
            Id = id;
            Name = name;
            UniverseGroup = universeGroup;
        }

        public PlanetViewModel(PlanetViewModel planetid)
        {
        }
    }
}

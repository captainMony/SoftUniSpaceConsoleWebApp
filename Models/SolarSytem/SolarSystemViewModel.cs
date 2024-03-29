using SoftUniSpaceConsoleWebApp.Models.Ship;

namespace SoftUniSpaceConsoleWebApp.Models.SolarSystem
{
    public class SolarSystemViewModel
    {
        public int Id { get; set; } // bruh
        public string Name { get; set; }
        public string UniverseGroup { get; set; }

        public SolarSystemViewModel(int id, string name, string universeGroup)
        {
            Id = id;
            Name = name;
            UniverseGroup = universeGroup;
        }

        public SolarSystemViewModel(SolarSystemViewModel systemid)
        {
        }
    }
}

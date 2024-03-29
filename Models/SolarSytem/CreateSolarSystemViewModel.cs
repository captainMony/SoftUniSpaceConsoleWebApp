namespace SoftUniSpaceConsoleWebApp.Models.SolarSystem
{
    public class CreateSolarSystemViewModel
    {
        string Name { get; set; }

        string UniverseGroup { get; set; }

        public CreateSolarSystemViewModel(string name, string universeGroup)
        {
            Name = name;
            UniverseGroup = universeGroup;
        }
    }
}

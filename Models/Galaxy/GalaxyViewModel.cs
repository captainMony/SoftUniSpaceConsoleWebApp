namespace SoftUniSpaceConsoleWebApp.Models.Galaxy
{
    public class GalaxyViewModel
    {
     
        public int Id { get; set; }
     
        public string Name { get; set; }

      
        public string Color { get; set; }

        public string UniverseGroup { get; set; } //Try for Fk key??

        public GalaxyViewModel(int id, string name, string color, string universeGroup)
        {
            Id = id;
            Name = name;
            Color = color;
            UniverseGroup = universeGroup;
        }

        public GalaxyViewModel(int id)
        {
            Id = id;
        }
    }
}

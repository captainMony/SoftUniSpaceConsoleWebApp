using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class SpaceStation
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        public string UniverseGroup { get; set; }

        public SpaceStation(string name, string universeGroup)
        {
            Name = name;
            UniverseGroup = universeGroup;
        }
    }
}

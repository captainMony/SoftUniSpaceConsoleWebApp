using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class Planet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string UniverseGroup { get; set; }

        public Planet(string name, string type)
        {
            Name = name;
            Type = type;
            UniverseGroup = universeGroup;
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class Galaxy
    {
        public Galaxy(string name, string color, string universeGroup)
        {
            Name = name;
            Color = color;
            UniverseGroup = universeGroup;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string UniverseGroup { get; set; } //Try for Fk key??







    }
}

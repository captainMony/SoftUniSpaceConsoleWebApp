using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public string UniverseGroup { get; set; }

        public Cargo(string type, string name, double quantity)
        {
            Type = type;
            Name = name;
            Quantity = quantity;
            UniverseGroup = universeGroup;
        }
    }
}

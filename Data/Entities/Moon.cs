using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class Moon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Size { get; set; }    

        [Required]
        public string UniverseGroup { get; set; }

        public Moon(string name, string size, string universeGroup)
        {
            Name = name;
            Size = size;
            UniverseGroup = universeGroup;
        }
    }
}

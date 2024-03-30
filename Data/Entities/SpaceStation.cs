using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class SpaceStation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public SpaceStation(string name)
        {
            Name = name;
        }
    }
}

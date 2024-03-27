using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class SolarSystem
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public SolarSystem(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}

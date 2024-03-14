using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class Crew
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
        [Required]
        public string Rank { get; set; }

    }
}

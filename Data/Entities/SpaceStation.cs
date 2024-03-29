using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class SpaceStation
    {
        [Key]

        public int SpaceStationId { get; set; }

        [Required]

        public string SpaceStationName { get; set; }

        [Required]
        public string UniverseGroup { get; set; }






    }
}

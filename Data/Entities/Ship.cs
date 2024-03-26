using System.ComponentModel.DataAnnotations;

namespace SoftUniSpaceConsoleWebApp.Data.Entities
{
    public class Ship
    {
        [Key]
        public int ShipId { get; set; }

        [Required]
        public string ShipName { get; set; }

        [Required]
        public int ShipAge { get; set; } //Years old like Crew

        public Ship(string shipName, int shipAge)
        {
            ShipName = shipName;
            ShipAge = shipAge;
        }
    }
}

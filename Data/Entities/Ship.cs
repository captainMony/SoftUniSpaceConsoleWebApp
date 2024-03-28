using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        [ForeignKey("ShipCrew")]
        public int FkCrewId { get; set; }

        public virtual Crew ShipCrew { get; set; }


        public Ship(string shipName, int shipAge)
        {
            ShipName = shipName;
            ShipAge = shipAge;
        }
    }
}

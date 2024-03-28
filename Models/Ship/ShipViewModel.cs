namespace SoftUniSpaceConsoleWebApp.Models.Ship
{
    public class ShipViewModel
    {

        public int ShipId { get; set; } // bruh

        public string ShipName { get; set; }

        public int ShipAge { get; set; }

        public ShipViewModel(int shipId, string shipName, int shipAge)
        {
            ShipId = shipId;
            ShipName = shipName;
            ShipAge = shipAge;
        }
    }
}

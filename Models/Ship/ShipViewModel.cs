namespace SoftUniSpaceConsoleWebApp.Models.Ship
{
    public class ShipViewModel
    {

        public int ShipId { get; set; } // bruh

        public string ShipName { get; set; }

        public int ShipAge { get; set; }

        public string UniverseGroup {  get; set; }
        public ShipViewModel Shipid { get; }

        public ShipViewModel(int shipId, string shipName, int shipAge,string universeGroup)
        {
            ShipId = shipId;
            ShipName = shipName;
            ShipAge = shipAge;
            UniverseGroup = universeGroup;  
        }

        public ShipViewModel(ShipViewModel shipid)
        {
            Shipid = shipid;
        }
    }
}

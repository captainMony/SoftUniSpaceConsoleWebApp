namespace SoftUniSpaceConsoleWebApp.Models.Ship
{
    public class CreateShipViewModel
    {

        //Used as a model to create in controller. Whne created we dont make the id, thats why we dont have an id in this viewmodel!

        public string ShipName { get; set; }

        public int ShipAge { get; set; }    

        public string UniverseGroup { get; set; }


    }
}

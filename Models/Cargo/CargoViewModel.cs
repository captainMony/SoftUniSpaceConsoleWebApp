namespace SoftUniSpaceConsoleWebApp.Models.Cargo
{
    public class CargoViewModel
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public string UniverseGroup { get; set; }

        public CargoViewModel(int id, string type, string name, double quantity)
        {
            Id = id;
            Type = type;
            Name = name;
            Quantity = quantity;
            UniverseGroup = universeGroup;
        }
    }
}

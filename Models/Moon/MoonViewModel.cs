
namespace SoftUniSpaceConsoleWebApp.Models.Moon
{
    public class MoonViewModel
    {     
        public MoonViewModel(Data.Entities.Moon moonid)
        {
        }

        public MoonViewModel(int id, string size, string universeGroup)
        {
            Id = id;
            Size = size;
            UniverseGroup = universeGroup;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string UniverseGroup { get; set; }
         

    }
}

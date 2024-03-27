using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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

        public Crew() { }

      //  public Crew(int id, string name, int age,string rank) ?????????
      //      : this(name, age, rank)
      //  {
      //      Id = id;
      //  }

        public Crew( string name, int age, string rank)
        {
            Name = name;
            Age = age;
            Rank = rank;
        }
    }
}

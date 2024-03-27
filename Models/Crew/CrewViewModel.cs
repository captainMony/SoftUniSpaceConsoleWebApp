namespace SoftUniSpaceConsoleWebApp.Models.Crew
{
    public class CrewViewModel
    {

        public int Id { get; set; } // bruh

        public string Name { get; set; }

        public int Age { get; set; }

        public string Rank { get; set; }


       public CrewViewModel(int id, string name, int age, string rank)
       {
           Id = id;
           Name = name;
           Age = age;
           Rank = rank;
       }

        public CrewViewModel(CrewViewModel crewid)
        {
        }
    }
}

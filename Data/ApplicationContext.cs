using Microsoft.EntityFrameworkCore;
using SoftUniSpaceConsoleWebApp.Data.Entities;


namespace SoftUniSpaceConsoleWebApp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Crew> Crewmen {  get; set; } //Its CrewMEN cuz plural? && From here we interact with database? Read,Delete,Create...

        public DbSet<Ship> Ship { get; set; }  //Also name of the table in the DB

        public DbSet<SolarSystem> SolarSystem { get; set; } //

        public DbSet<SpaceStation> SpaceStation { get; set; }   //NOT DONE

        public DbSet<Planet> Planet { get; set; }

        public DbSet<Galaxy> Galaxy { get; set; }
        
        
        public DbSet<Moon> Moon { get; set; } //barte?

        public DbSet<SpaceStation> SpaceStations { get; set; } //master

        public ApplicationContext(DbContextOptions<ApplicationContext>options) 
            :base(options)
        { }

    }
}


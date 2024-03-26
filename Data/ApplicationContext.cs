using Microsoft.EntityFrameworkCore;
using SoftUniSpaceConsoleWebApp.Data.Entities;


namespace SoftUniSpaceConsoleWebApp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Crew> Crewmen {  get; set; } //Should be crewMAN btw || From here we interact with database? Read,Delete,Create...

        public DbSet<Ship> Ship { get; set; }  

        public ApplicationContext(DbContextOptions<ApplicationContext>options) 
            :base(options)
        { }
    }
}

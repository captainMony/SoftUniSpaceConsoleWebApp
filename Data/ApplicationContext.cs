using Microsoft.EntityFrameworkCore;
using SoftUniSpaceConsoleWebApp.Data.Entities;


namespace SoftUniSpaceConsoleWebApp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Crew> Crewmen {  get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext>options) 
            :base(options)
        { }
    }
}

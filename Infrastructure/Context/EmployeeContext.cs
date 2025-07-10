using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Registration> Registration { get; set; }
        //public DbSet<Departments> Departments { get; set; }
        //public DbSet<Languages> Languages { get; set; }
        //public DbSet<LanguageMapping> LanguageMapping { get; set; }
        //public DbSet<Region> Region { get; set; }
        //public DbSet<Difficulty> Difficulty { get; set; }
        //public DbSet<Walk> Walk { get; set; }
    }
}

using DMAWS_T2108E_LeDuyDuoc.Models;
using Microsoft.EntityFrameworkCore;

namespace DMAWS_T2108E_LeDuyDuoc.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Emloyee> Emloyees { get; set; }
        public DbSet<ProjectEmloyee> ProjectEmloyees { get; set; }
    }
}

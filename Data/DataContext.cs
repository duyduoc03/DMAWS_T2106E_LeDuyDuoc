using DMAWS_T2108E_LeDuyDuoc.Models;
using Microsoft.EntityFrameworkCore;

namespace DMAWS_T2108E_LeDuyDuoc.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Emloyees { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeDOB)
                .IsRequired()
                .HasColumnType("date");

            modelBuilder.Entity<Employee>()
                .HasCheckConstraint("CK_Employee_DOB", "DATEDIFF(year, EmployeeDOB, GETDATE()) >= 16");

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.EmployeeName);

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.EmployeeDepartment);


            modelBuilder.Entity<Project>()
            .HasCheckConstraint("CK_Project_StartDate_EndDate", "ProjectEndDate IS NULL OR ProjectStartDate < ProjectEndDate");

            modelBuilder.Entity<Project>()
                .HasIndex(p => p.ProjectName);

            modelBuilder.Entity<ProjectEmployee>()
            .HasKey(pe => new { pe.ProjectId, pe.EmployeeId });
        }

    }
}

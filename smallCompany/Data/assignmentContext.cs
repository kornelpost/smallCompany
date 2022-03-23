using smallCompany.Models;
using Microsoft.EntityFrameworkCore;


namespace smallCompany.Data
{
    public class AssignmentContext : DbContext
    {
        public AssignmentContext(DbContextOptions<AssignmentContext> options) : base(options)
        {
        }


        public DbSet<Task> Tasks { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Task>().ToTable("Task");
        }
    }
    
}

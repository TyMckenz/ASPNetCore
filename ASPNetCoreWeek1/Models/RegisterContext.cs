
using ASPNetCoreWeek1.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCore.Models
{
    public class RegisterContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-90OJ2U4P\SQLEXPRESS;Database=University;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasMany(c => c.Students1).WithMany(s => s.Courses);
            modelBuilder.Entity<Professor>().HasOne(p => p.ProfCourse);
            modelBuilder.Entity<Professor>().HasKey(p => p.ProfId);
        }
    }

}


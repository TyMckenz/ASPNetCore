
using ASPNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCore.Models
{
    public class RegisterContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
    }
}

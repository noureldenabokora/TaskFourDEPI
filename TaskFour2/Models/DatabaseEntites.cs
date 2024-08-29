using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace TaskFour2.Models
{
    public class DatabaseEntites :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("server= DESKTOP-626PATH\\SQLEXPRESS; database =taskfourescond;Integrated Security=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  modelBuilder.

        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseResult> CourseResults { get; set; }
        public DbSet<Trainne> Trainnes { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;

namespace UniversityRegistrar
{
    public class UniversityRegistrar : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Port=8889;database=university_registrar;uid=root;pwd=root;");
        }
    }
}
using AspDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
        {
             
        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseResult> CourseResults { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Instructore> Instructores { get; set; }
    }
}

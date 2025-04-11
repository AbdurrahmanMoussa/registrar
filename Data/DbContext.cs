using Microsoft.EntityFrameworkCore;
using Registrar;


namespace Registrar.Data
{
    public class RegistrarDbContext : DbContext
    {
        public RegistrarDbContext(DbContextOptions<RegistrarDbContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Registration> Registration { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>().HasKey(r => new
            {
                r.StudentId,
                r.CourseId
            });
            modelBuilder.Entity<Registration>().HasOne(r => r.Student).WithMany(s => s.Registrations).HasForeignKey(r=>r.StudentId);
            modelBuilder.Entity<Registration>().HasOne(c => c.Course).WithMany(c => c.Registrations).HasForeignKey(r=>r.CourseId);
        }

    }

}
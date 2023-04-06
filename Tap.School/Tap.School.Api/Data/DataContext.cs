using Microsoft.EntityFrameworkCore;
using Tap.School.Api.Entities;

namespace Tap.School.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Student> Students { get; set; }

        //Exposed Grade to the DB
        public DbSet<Grade> Grades { get; set; }

        //Exercise 11
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .HasMaxLength(150)

                entity.Property(e => e.LastName)
                    .IsRequired();
            });
        }
    }
}

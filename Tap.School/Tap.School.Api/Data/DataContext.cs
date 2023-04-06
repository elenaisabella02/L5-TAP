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
    }
}

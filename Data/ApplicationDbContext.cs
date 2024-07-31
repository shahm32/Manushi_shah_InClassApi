using Microsoft.EntityFrameworkCore;
using Manushi_shah_InClassApi.Models;
namespace Manushi_shah_InClassApi.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}

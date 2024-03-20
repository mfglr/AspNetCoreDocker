using Microsoft.EntityFrameworkCore;

namespace microservice1.API.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

    }
}

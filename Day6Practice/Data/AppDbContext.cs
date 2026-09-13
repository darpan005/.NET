using Microsoft.EntityFrameworkCore;
using Day6.Models;

namespace Day6Practice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
                : base(options)
        {
            
        }

        public DbSet<Product> Products {get; set;}
    }
}
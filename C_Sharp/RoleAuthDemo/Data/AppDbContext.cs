using Microsoft.EntityFrameworkCore;
using RoleAuthDemo.Models;

namespace RoleAuthDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<User> Users {get; set;}
        public DbSet<Item> items {get; set;}

    }
}
using AllForOne_Store.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllForOne_Store.Data
{
    public class AppDbContext: IdentityDbContext<Users>
    {
         public AppDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Security> Securities { get; set; }
    }
}

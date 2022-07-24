using EticaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EticaretAPI.Persistence.Contexts
{
    public class EticaretAPIDbContext : DbContext
    {
        public EticaretAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
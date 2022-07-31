using EticaretAPI.Domain.Entities;
using EticaretAPI.Domain.Entities.Common;
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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                var _ = data.State switch
                {
                    EntityState.Modified => data.Entity.UpdatedDate=DateTime.UtcNow,
                    EntityState.Added => data.Entity.CreatedDate=DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
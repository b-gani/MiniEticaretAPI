using EticaretAPI.Application.Repositories;
using EticaretAPI.Domain.Entities;
using EticaretAPI.Persistence.Contexts;

namespace EticaretAPI.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EticaretAPIDbContext context) : base(context)
        {
        }
    }
}
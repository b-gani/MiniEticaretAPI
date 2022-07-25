﻿using EticaretAPI.Application.Repositories;
using EticaretAPI.Domain.Entities;
using EticaretAPI.Persistence.Contexts;

namespace EticaretAPI.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EticaretAPIDbContext context) : base(context)
        {
        }
    }
}
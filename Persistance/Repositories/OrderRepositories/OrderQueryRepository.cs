using Domain.Entities;
using Domain.Repositories.OrderRepositories;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.OrderRepositories;
public sealed class OrderQueryRepository : QueryRepository<Order>, IOrderQueryRepository
{
    public OrderQueryRepository(AppDbContext context) : base(context)
    {
    }
}
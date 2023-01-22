using Domain.Entities;
using Domain.Repositories.OrderRepositories;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.OrderRepositories;
public sealed class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
{
    public OrderCommandRepository(AppDbContext context) : base(context)
    {
    }
}

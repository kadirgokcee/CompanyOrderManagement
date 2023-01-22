using Domain.Entities;
using Domain.Repositories.ProductRepositories;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.ProductRepositories;
public sealed class ProductCommandRepository : CommandRepository<Product>, IProductCommandRepository
{
    public ProductCommandRepository(AppDbContext context) : base(context)
    {
    }
}
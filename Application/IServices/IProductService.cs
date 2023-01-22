using Application.Features.Products.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices;
public interface IProductService
{
    Task AddAsync(CreateProductCommand request);
}
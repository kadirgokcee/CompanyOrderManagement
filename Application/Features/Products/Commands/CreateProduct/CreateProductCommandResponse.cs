using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Commands.CreateProduct;
public sealed record CreateProductCommandResponse(
    string Message = "Ürünüz başarıyla eklenmiştir!");
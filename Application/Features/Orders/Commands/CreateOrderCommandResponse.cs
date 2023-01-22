using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Orders.Commands;
public sealed record CreateOrderCommandResponse(
    string Message = "Sipariş kaydınız başarıyla oluşturulmuştur!");
using Application.Features.Orders.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices;
public interface IOrderService
{
    Task CreateOrder(CreateOrderCommand request);
}
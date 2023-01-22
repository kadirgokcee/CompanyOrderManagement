using Application.Features.Orders.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller;
public sealed class OrdersController : ApiController
{
    public OrdersController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
    {
        CreateOrderCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
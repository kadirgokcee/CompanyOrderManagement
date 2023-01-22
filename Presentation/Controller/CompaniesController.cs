using Application.Features.Companies.Commands.CreateCompany;
using Application.Features.Companies.Commands.Queries;
using Application.Features.Companies.Commands.UpdateCompany;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller;

public class CompaniesController : ApiController
{
    public CompaniesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateCompany(CreateCompanyCommand request)
    {
        CreateCompanyCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> UpdateCompany(UpdateCompanyCommand request)
    {
        UpdateCompanyCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetAllCompany()
    {
        GetAllCompanyQuery request = new();
        GetAllCompanyQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }

}
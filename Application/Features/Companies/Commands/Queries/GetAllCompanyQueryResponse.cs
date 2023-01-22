using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Companies.Commands.Queries;
public sealed record GetAllCompanyQueryResponse(
    IQueryable<Company> Companies);

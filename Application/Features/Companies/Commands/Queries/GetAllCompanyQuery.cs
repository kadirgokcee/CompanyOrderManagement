using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Companies.Commands.Queries;


public sealed record GetAllCompanyQuery : IRequest<GetAllCompanyQueryResponse>;
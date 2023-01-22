using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Companies.Commands.CreateCompany;
public sealed record CreateCompanyCommand(
    string CompanyName,
    int OrderStartTimeHour,
    int OrderStartTimeMinute,
    int OrderFinishTimeHour,
    int OrderFinishTimeMinute) : IRequest<CreateCompanyCommandResponse>;
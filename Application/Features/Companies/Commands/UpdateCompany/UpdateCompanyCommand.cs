using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Companies.Commands.UpdateCompany;
public sealed record UpdateCompanyCommand(
    string CompanyId,
    int OrderStartTimeHour,
    int OrderStartTimeMinute) : IRequest<UpdateCompanyCommandResponse>;

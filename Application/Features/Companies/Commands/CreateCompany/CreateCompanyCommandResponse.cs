using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Companies.Commands.CreateCompany;
public sealed record CreateCompanyCommandResponse(
    string Message = "Şirket kaydınız oluşturulmuştur!");
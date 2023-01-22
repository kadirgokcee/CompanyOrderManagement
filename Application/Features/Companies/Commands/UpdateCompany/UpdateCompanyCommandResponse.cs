using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Companies.Commands.UpdateCompany;
public sealed record UpdateCompanyCommandResponse(
    string Message = "Şirket kaydınız başarıyla güncellenmiştir");
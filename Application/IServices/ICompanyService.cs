using Application.Features.Companies.Commands.CreateCompany;
using Application.Features.Companies.Commands.UpdateCompany;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices;

public interface ICompanyService
{
    Task CreateCompanyAsync(CreateCompanyCommand request);
    Task UpdateCompanyAsync(UpdateCompanyCommand request);
    IQueryable<Company> GetAll();
    Task<Company> GetCompanyById(string companyId);
}
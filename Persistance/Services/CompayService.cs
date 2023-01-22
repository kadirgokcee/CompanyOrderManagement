using Application.Features.Companies.Commands.CreateCompany;
using Application.Features.Companies.Commands.UpdateCompany;
using Application.IServices;
using Domain.Entities;
using Domain.IUnitOfWork;
using Domain.Repositories.CompanyRepositories;
using Domain.Repositories.CompanyRepositoriesİ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Services;
public sealed class CompanyService : ICompanyService
{
    private readonly ICompanyCommandRepository _companyCommandRepositories;
    private readonly ICompanyQueryRepository _companyQueryRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CompanyService(ICompanyCommandRepository companyCommandRepositories, ICompanyQueryRepository companyQueryRepository, IUnitOfWork unitOfWork)
    {
        _companyCommandRepositories = companyCommandRepositories;
        _companyQueryRepository = companyQueryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateCompanyAsync(CreateCompanyCommand request)
    {
        Company company = new()
        {
            Id = Guid.NewGuid().ToString(),
            ApprovalStatus = false,
            CompanyName = request.CompanyName,
            CreatedDate = DateTime.Now,
            OrderStartTimeHour = request.OrderStartTimeHour,
            OrderStartTimeMinute = request.OrderStartTimeMinute,
            OrderFinishTimeHour = request.OrderFinishTimeHour,
            OrderFinishTimeMinute = request.OrderFinishTimeMinute,
        };
        await _companyCommandRepositories.AddAsync(company);
        await _unitOfWork.SaveChangesAsync();
    }

    public IQueryable<Company> GetAll()
    {
        return _companyQueryRepository.GetAll();
    }

    public async Task<Company> GetCompanyById(string companyId)
    {
        return await _companyQueryRepository.GetFirstById(companyId);
    }

    public async Task UpdateCompanyAsync(UpdateCompanyCommand request)
    {
        var company = await _companyQueryRepository.GetFirstById(request.CompanyId);
        if (company == null) throw new Exception("Şirket kaydı bulunamadı!");
        if (company.ApprovalStatus) throw new Exception("Şirket zaten onaylı!");

        company.ApprovalStatus = true;
        company.OrderStartTimeHour = request.OrderStartTimeHour;
        company.OrderStartTimeMinute = request.OrderStartTimeMinute;
        _companyCommandRepositories.Update(company);
        await _unitOfWork.SaveChangesAsync();
    }
}
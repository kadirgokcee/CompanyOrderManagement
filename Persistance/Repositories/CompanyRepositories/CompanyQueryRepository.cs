using Domain.Entities;
using Domain.Repositories.CompanyRepositoriesİ;
using Domain.Repositories;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CompanyRepositories;
public sealed class CompanyQueryRepository : QueryRepository<Company>, ICompanyQueryRepository
{
    public CompanyQueryRepository(AppDbContext context) : base(context)
    {
    }
}
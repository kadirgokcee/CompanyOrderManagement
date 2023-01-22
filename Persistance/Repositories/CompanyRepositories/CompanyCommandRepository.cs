using Domain.Entities;
using Domain.Repositories.CompanyRepositories;
using Domain.Repositories;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CompanyRepositories;
public sealed class CompanyCommandRepository : CommandRepository<Company>, ICompanyCommandRepository
{
    public CompanyCommandRepository(AppDbContext context) : base(context)
    {
    }
}
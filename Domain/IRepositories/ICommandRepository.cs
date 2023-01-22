using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories;
public interface ICommandRepository<T> : IRepository<T>
    where T : Entity
{
    Task AddAsync(T entity);
    void Update(T entity);
    Task RemoveByIdAsync(string id);
    void Remove(T entity);
}

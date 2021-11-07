using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFake.Repositories
{
    public interface IRepository<T>
    {
        Task<T> Get(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task Save(T entity);
        Task Update(T entity);
        Task Remove(Guid id);
    }
}

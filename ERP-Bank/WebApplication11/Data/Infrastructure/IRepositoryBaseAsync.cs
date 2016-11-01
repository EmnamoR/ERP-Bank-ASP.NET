using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace bank.Data.Infrastructure
{
    public interface IRepositoryBaseAsync<T> : IRepositoryBase<T>
     where T : class
    {
        Task<int> CountAsync();
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        Task<List<T>> GetAllAsync();

    }
}

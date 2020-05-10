using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T: class
    {
        Task<T> Add(T element);
        Task<T> Update(T element);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);        
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);                       
        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);

    }
}

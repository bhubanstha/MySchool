using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Data.Interface
{
    public interface ICrud<T> where T: class
    {
        Task<int> Create(T obj);
        Task<int> Update(int Id, T obj);
        Task<int> Delete(int Id);
        Task<int> Delete(T obj);

        
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(int pageNo, int pageSize);
        Task<T> Single(int id);
        Task<T> Single(Expression<Func<T, bool>> expression);
    }
}

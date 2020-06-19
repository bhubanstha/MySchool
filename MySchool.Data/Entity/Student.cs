using MySchool.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Data.Entity
{
    public class Student :  ICrud<Student>, IDisposable
    {
        public Task<int> Create(Student obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Student obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAll(int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Single(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Single(Expression<Func<Student, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int Id, Student obj)
        {
            throw new NotImplementedException();
        }
    }
}

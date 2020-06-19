using Microsoft.EntityFrameworkCore;
using MySchool.Data.Context;
using MySchool.Data.Entity;
using MySchool.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Data.GenRepo
{
    public class Repository<T> : ICrud<T> where T : BaseEntity
    {
        public MySchoolContext Context { get; set; }
        private DbSet<T> entities;

        public Repository()
        {

        }

        public Repository(MySchoolContext context)
        {
            Context = context;
            entities = context.Set<T>();
        }
        public async Task<int> Create(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Delete(int Id)
        {
            T obj = await Single(Id);
            if (obj != null)
            {
                entities.Remove(obj);
                return await Context.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<int> Delete(T obj)
        {
            if(obj != null)
            {
                entities.Remove(obj);
                return await Context.SaveChangesAsync();
            }
            return -1;   
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return  entities.AsEnumerable<T>();
        }

        public async Task<IEnumerable<T>> GetAll(int pageNo, int pageSize)
        {
            return  entities.AsQueryable()
                .Skip(pageSize * (pageNo - 1))
                .Take(pageSize);
        }

        public Task<T> Single(int id)
        {
            T obj = entities.Where(x => x.Id == id).FirstOrDefault();
            if (obj != null)
                return Task.FromResult(obj);

            return null;
        }

        public async Task<T> Single(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(int Id, T obj)
        {
            T objExisting = await Single(Id);
            if(objExisting != null)
            {
                obj.Id = objExisting.Id;
                await entities.AddAsync(obj);
                Context.Entry(obj).State = EntityState.Modified;
                return await Context.SaveChangesAsync();
            }
            return -1;


        }
    }
}

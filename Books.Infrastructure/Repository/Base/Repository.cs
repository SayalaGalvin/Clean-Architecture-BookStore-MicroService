using Books.Core.Repository.Base;
using Books.Infrastructure.DataService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Books.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly BookContext _bookContext;

        public Repository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _bookContext.Set<T>().AddAsync(entity);
            await _bookContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _bookContext.Set<T>().Remove(entity);
            await _bookContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _bookContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _bookContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _bookContext.Entry(entity).State = EntityState.Modified;
            await _bookContext.SaveChangesAsync();
        }
    }
}

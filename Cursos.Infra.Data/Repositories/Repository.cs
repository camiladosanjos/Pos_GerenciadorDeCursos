using Cursos.Domain.Interfaces.Repositories;
using Cursos.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cursos.Infra.Data.Repositories
{
    public class Repository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        private readonly CursosDbContext _context;
        public Repository(CursosDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public T Find(Guid id)
        {
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<T> List()
        {
            try
            {
                var result = _context.Set<T>().AsNoTracking().ToList();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Remove(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

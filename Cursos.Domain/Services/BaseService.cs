using Cursos.Domain.Interfaces.Repositories;
using Cursos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public IEnumerable<T> List()
        {
            return _baseRepository.List();
        }

        public void Add(T entity)
        {
            _baseRepository.Add(entity);
        }

        public T Find(Guid id)
        {
            return _baseRepository.Find(id);
        }

        public void Remove(T entity)
        {
            _baseRepository.Remove(entity);
        }

        public void Update(T entity)
        {
            _baseRepository.Update(entity);
        }
    }
}

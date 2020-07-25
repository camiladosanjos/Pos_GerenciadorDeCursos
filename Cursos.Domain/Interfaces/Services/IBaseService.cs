using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        IEnumerable<T> List();
        void Add(T entity);
        void Remove(T id);
        void Update(T entity);
        T Find(Guid id);
    }
}

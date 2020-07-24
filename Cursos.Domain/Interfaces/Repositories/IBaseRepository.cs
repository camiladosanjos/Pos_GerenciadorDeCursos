using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T: class
    {
        IEnumerable<T> List { get; }
        int Add(T entity);
        void Remove(int id);
        void Update(T entity);
        T Find(int Id);
    }
}

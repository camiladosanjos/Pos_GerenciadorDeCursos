using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Interfaces.Services
{
    public interface IBaseService<T> where T: class
    {
        IEnumerable<T> List { get; }
        int Add(T entity);
        void Remove(int id);
        void Update(T entity);
        T Find(int Id);
    }
}

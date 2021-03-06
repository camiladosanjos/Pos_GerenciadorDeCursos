﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> List();
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T Find(Guid entity);
    }
}

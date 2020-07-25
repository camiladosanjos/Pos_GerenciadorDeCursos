using Cursos.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.Intefaces
{
    public interface ICursoApplication
    {
        IEnumerable<CursoViewModel> List();
        void Add(CursoViewModel curso);
        void Remove(CursoViewModel curso);
        void Update(CursoViewModel curso);
        CursoViewModel Find(Guid id);
    }
}

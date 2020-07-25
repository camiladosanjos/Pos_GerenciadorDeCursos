using Cursos.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.Intefaces
{
    public interface IDisciplinaApplication
    {
        IEnumerable<DisciplinaViewModel> List();
        void Add(DisciplinaViewModel disciplina);
        void Remove(Guid id);
        void Update(DisciplinaViewModel disciplina);
        DisciplinaViewModel Find(Guid id);
    }
}

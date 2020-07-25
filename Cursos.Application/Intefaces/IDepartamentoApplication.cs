using Cursos.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.Intefaces
{
    public interface IDepartamentoApplication
    {
        IEnumerable<DepartamentoViewModel> List();
        void Add(DepartamentoViewModel departamento);
        void Remove(Guid id);
        void Update(DepartamentoViewModel departamento);
        DepartamentoViewModel Find(Guid id);
    }
}

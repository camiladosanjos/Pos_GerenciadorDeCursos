using Cursos.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.Intefaces
{
    public interface IInstituicaoApplication
    {
        IEnumerable<InstituicaoViewModel> List();
        void Add(InstituicaoViewModel instituicao);
        void Remove(Guid id);
        void Update(InstituicaoViewModel instituicao);
        InstituicaoViewModel Find(Guid id);
    }
}

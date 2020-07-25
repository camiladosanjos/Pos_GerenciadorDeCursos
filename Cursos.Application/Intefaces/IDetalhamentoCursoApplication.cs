using Cursos.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.Intefaces
{
    public interface IDetalhamentoCursoApplication
    {
        IEnumerable<DetalhamentoCursoViewModel> List();
        void Add(DetalhamentoCursoViewModel detalhamentoCurso);
        void Remove(DetalhamentoCursoViewModel detalhamentoCurso);
        void Update(DetalhamentoCursoViewModel detalhamentoCurso);
        DetalhamentoCursoViewModel Find(Guid id);
    }
}

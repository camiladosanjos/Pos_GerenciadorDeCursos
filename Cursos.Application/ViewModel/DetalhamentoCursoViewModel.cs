using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class DetalhamentoCursoViewModel
    {
        public Guid CursoId { get; set; }
        public CursoViewModel Curso { get; set; }

        public Guid DisciplinaId { get; set; }
        public DisciplinaViewModel Disciplina { get; set; }
    }
}

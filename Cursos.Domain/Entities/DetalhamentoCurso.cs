using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Entities
{
    public class DetalhamentoCurso
    {
        public Guid CursoId { get; set; }
        public Curso Curso { get; set; }

        public Guid DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}

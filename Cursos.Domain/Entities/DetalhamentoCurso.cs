using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Entities
{
    public class DetalhamentoCurso
    {
        public Guid CursoDisciplinaId { get; set; }
        public Curso CursoDisciplina { get; set; }

        public Guid DisciplinaCursoId { get; set; }
        public Disciplina DisciplinaCurso { get; set; }
    }
}

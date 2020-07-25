using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class DetalhamentoCursoViewModel
    {
        public Guid CursoDisciplinaId { get; set; }
        public CursoViewModel CursoDisciplina { get; set; }

        public Guid DisciplinaCursoId { get; set; }
        public DisciplinaViewModel DisciplinaCurso { get; set; }
    }
}

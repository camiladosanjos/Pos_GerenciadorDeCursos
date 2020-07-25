using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class DisciplinaViewModel
    {
        public DisciplinaViewModel()
        {
            DisciplinaId = new Guid();
        }

        public Guid DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public IList<CursoViewModel> ListCursos { get; set; }

    }
}

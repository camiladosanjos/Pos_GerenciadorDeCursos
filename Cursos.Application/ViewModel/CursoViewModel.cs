using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class CursoViewModel
    {
        public CursoViewModel()
        {
            CursoId = new Guid();
        }

        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public DepartamentoViewModel Departamento { get; set; }
        public IList<DisciplinaViewModel> ListDisciplinas { get; set; }

    }
}

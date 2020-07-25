using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class DepartamentoViewModel
    {
        public DepartamentoViewModel()
        {
            DepartamentoId = new Guid();
        }

        public Guid DepartamentoId { get; set; }
        public string Nome { get; set; }
        public InstituicaoViewModel Instituicao { get; set; }
        public IList<CursoViewModel> ListCursos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class DepartamentoViewModel
    {
        public Guid DepartamentoId { get; set; }
        public string Nome { get; set; }
        public Guid InstituicaoId { get; set; }
        public virtual InstituicaoViewModel Instituicao { get; set; }
        public ICollection<CursoViewModel> Cursos { get; set; }
        public DepartamentoViewModel()
        {
            Cursos = new List<CursoViewModel>();
            DepartamentoId = new Guid();
        }
    }
}

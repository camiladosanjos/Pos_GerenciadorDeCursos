using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class CursoViewModel
    {
        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public Guid DepartamentoId { get; set; }
        public virtual DepartamentoViewModel Departamento { get; set; }
        public ICollection<DetalhamentoCursoViewModel> Disciplina { get; set; }
        public CursoViewModel()
        {
            Disciplina = new List<DetalhamentoCursoViewModel>();
            CursoId = new Guid();
        }
    }
}

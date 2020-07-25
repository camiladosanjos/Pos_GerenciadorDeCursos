using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class DisciplinaViewModel
    {
        public Guid DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public ICollection<DetalhamentoCursoViewModel> Cursos { get; set; }
        public DisciplinaViewModel()
        {
            Cursos = new List<DetalhamentoCursoViewModel>();
            DisciplinaId = new Guid();
        }
    }
}

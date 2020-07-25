using System;
using System.Collections.Generic;

namespace Cursos.Domain.Entities
{
    public class Curso
    {
        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public Guid DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }
        public ICollection<DetalhamentoCurso> Disciplina { get; set; }
        public Curso()
        {
            Disciplina = new List<DetalhamentoCurso>();
            CursoId = new Guid();
        }
    }
}

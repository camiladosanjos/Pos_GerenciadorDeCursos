using System;
using System.Collections.Generic;

namespace Cursos.Domain.Entities
{
    public class Departamento
    {
        public Guid DepartamentoId { get; set; }
        public string Nome { get; set; }
        public Guid InstituicaoId { get; set; }
        public virtual Instituicao Instituicao { get; set; }
        public ICollection<Curso> Cursos { get; set; }
        public Departamento()
        {
            Cursos = new List<Curso>();
            DepartamentoId = new Guid();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Cursos.Domain.Entities
{
    public class Departamento
    {
        public Departamento()
        {
            DepartamentoId = new Guid();
        }

        public Guid DepartamentoId { get; set; }
        public string Nome { get; set; }
        public Instituicao Instituicao { get; set; }
        public IList<Curso> ListCursos { get; set; }
    }
}

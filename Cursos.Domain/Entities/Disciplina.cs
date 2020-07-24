using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Entities
{
    public class Disciplina
    {
        public Guid DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
    }
}

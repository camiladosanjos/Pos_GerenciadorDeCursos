using System;
using System.Collections.Generic;

namespace Cursos.Domain.Entities
{
    public class Curso
    {
        public Curso()
        {
            CursoId = new Guid();
        }

        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public Departamento Departamento { get; set; }
        public IList<Disciplina> ListDisciplinas { get; set; }
    }
}

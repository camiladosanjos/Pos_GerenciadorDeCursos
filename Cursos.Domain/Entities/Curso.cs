using System;

namespace Cursos.Domain.Entities
{
    public class Curso
    {
        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Entities
{
    public class Instituicao
    {
        public Instituicao()
        {
            InstituicaoId = new Guid();
        }

        public Guid InstituicaoId { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public IList<Departamento> ListDepartamentos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Entities
{
    public class Instituicao
    {
        public Guid InstituicaoId { get; set; }
        public string Nome { get; set; }
        public IList<Departamento> ListDepartamentos { get; set; }
        public Guid EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
        public Instituicao()
        {
            Departamentos = new List<Departamento>();
            InstituicaoId = new Guid();
        }
    }
}

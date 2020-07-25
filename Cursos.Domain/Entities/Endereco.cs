using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Entities
{
    public class Endereco
    {
        public Endereco()
        {
            EnderecoId = new Guid();
        }

        public Guid EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Guid InstituicaoId { get; set; }
        public virtual Instituicao Instituicao { get; set; }
    }
}

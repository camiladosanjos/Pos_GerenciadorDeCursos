using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class InstituicaoViewModel
    {
        public InstituicaoViewModel()
        {
            InstituicaoId = new Guid();
        }

        public Guid InstituicaoId { get; set; }
        public string Nome { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public IList<DepartamentoViewModel> ListDepartamentos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.ViewModel
{
    public class InstituicaoViewModel
    {
        public Guid InstituicaoId { get; set; }
        public string Nome { get; set; }
        public Guid EnderecoId { get; set; }
        public virtual EnderecoViewModel Endereco { get; set; }
        public ICollection<DepartamentoViewModel> Departamentos { get; set; }
        public InstituicaoViewModel()
        {
            Departamentos = new List<DepartamentoViewModel>();
            InstituicaoId = new Guid();
        }
    }
}

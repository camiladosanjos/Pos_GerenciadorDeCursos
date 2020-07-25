using Cursos.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.Intefaces
{
    public interface IEnderecoApplication
    {
        IEnumerable<EnderecoViewModel> List();
        void Add(EnderecoViewModel endereco);
        void Remove(Guid id);
        void Update(EnderecoViewModel endereco);
        EnderecoViewModel Find(Guid id);
    }
}

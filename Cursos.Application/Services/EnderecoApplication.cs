using AutoMapper;
using Cursos.Application.Intefaces;
using Cursos.Application.ViewModel;
using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.Services
{
    public class EnderecoApplication : IEnderecoApplication
    {
        private IEnderecoService _enderecoService;
        private IMapper _mapper;
        public EnderecoApplication(IEnderecoService enderecoService, IMapper mapper)
        {
            _enderecoService = enderecoService;
            _mapper = mapper;
        }
        public void Add(EnderecoViewModel endereco)
        {
            _enderecoService.Add(_mapper.Map<Endereco>(endereco));
        }

        public EnderecoViewModel Find(Guid id)
        {
            var endereco = _enderecoService.Find(id);
            return _mapper.Map<EnderecoViewModel>(endereco);   
        }

        public IEnumerable<EnderecoViewModel> List()
        {
            var enderecos = _enderecoService.List();
            return _mapper.Map<IEnumerable<EnderecoViewModel>>(enderecos);
        }

        public void Remove(Guid id)
        {
            _enderecoService.Remove(id);
        }

        public void Update(EnderecoViewModel endereco)
        {
            _enderecoService.Update(_mapper.Map<Endereco>(endereco));
        }
    }
}

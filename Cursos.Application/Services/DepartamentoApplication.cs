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
    public class DepartamentoApplication : IDepartamentoApplication
    {
        private readonly IDepartamentoService _departamentoService;
        private readonly IMapper _mapper;
        public DepartamentoApplication(IDepartamentoService departamentoService, IMapper mapper)
        {
            _departamentoService = departamentoService;
            _mapper = mapper;
        }
        public void Add(DepartamentoViewModel departamento)
        {
            _departamentoService.Add(_mapper.Map<Departamento>(departamento));
        }

        public DepartamentoViewModel Find(Guid id)
        {
            var departamento = _departamentoService.Find(id);
            return _mapper.Map<DepartamentoViewModel>(departamento);
        }

        public IEnumerable<DepartamentoViewModel> List()
        {
            var departamentos = _departamentoService.List();
            return _mapper.Map<IEnumerable<DepartamentoViewModel>>(departamentos);
        }

        public void Remove(DepartamentoViewModel departamento)
        {
            _departamentoService.Remove(_mapper.Map<Departamento>(departamento));
        }

        public void Update(DepartamentoViewModel departamento)
        {
            _departamentoService.Update(_mapper.Map<Departamento>(departamento));
        }
    }
}

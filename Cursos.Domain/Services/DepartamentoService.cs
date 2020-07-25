using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Services
{
    public class DepartamentoService : BaseService<Departamento>, IDepartamentoService
    {
        private IDepartamentoRepository _departamentoRepository;
        public DepartamentoService(IDepartamentoRepository departamentoRepository) : base(departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }
    }
}

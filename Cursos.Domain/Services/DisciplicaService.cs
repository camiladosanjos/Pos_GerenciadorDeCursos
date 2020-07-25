using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Services
{
    public class DisciplicaService : BaseService<Disciplina>, IDisciplicaService
    {
        private IDisciplicaRepository _disciplicaRepository;
        public DisciplicaService(IDisciplicaRepository disciplicaRepository) : base(disciplicaRepository)
        {
            _disciplicaRepository = disciplicaRepository;
        }
    }
}

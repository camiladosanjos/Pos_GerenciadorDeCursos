using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Services
{
    public class CursoService : BaseService<Curso>, ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        public CursoService(ICursoRepository cursoRepository) : base(cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
    }
}

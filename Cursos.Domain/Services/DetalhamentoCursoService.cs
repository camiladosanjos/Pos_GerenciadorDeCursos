using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Services
{
    public class DetalhamentoCursoService : BaseService<DetalhamentoCurso>, IDetalhamentoCursoService
    {
        private readonly IDetalhamentoCursoRepository _detalhamentoCursoRepository;
        public DetalhamentoCursoService(IDetalhamentoCursoRepository detalhamentoCursoRepository) : base(detalhamentoCursoRepository)
        {
            _detalhamentoCursoRepository = detalhamentoCursoRepository;
        }
    }
}

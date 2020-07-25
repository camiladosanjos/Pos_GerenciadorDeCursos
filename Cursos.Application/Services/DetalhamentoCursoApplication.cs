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
    public class DetalhamentoCursoApplication : IDetalhamentoCursoApplication
    {
        private readonly IDetalhamentoCursoService _detalhamentoCursoService;
        private IMapper _mapper;
        public DetalhamentoCursoApplication(IDetalhamentoCursoService detalhamentoCursoService, IMapper mapper)
        {
            _detalhamentoCursoService = detalhamentoCursoService;
            _mapper = mapper;
        }
        public void Add(DetalhamentoCursoViewModel detalhamentoCurso)
        {
            _detalhamentoCursoService.Add(_mapper.Map<DetalhamentoCurso>(detalhamentoCurso));
        }

        public DetalhamentoCursoViewModel Find(Guid id)
        {
            var detalhamentoCurso = _detalhamentoCursoService.Find(id);
            return _mapper.Map<DetalhamentoCursoViewModel>(detalhamentoCurso);
        }

        public IEnumerable<DetalhamentoCursoViewModel> List()
        {
            var detalhamentoCursos = _detalhamentoCursoService.List();
            return _mapper.Map<IEnumerable<DetalhamentoCursoViewModel>>(detalhamentoCursos);
        }

        public void Remove(Guid id)
        {
            _detalhamentoCursoService.Remove(id);
        }

        public void Update(DetalhamentoCursoViewModel detalhamentoCurso)
        {
            _detalhamentoCursoService.Update(_mapper.Map<DetalhamentoCurso>(detalhamentoCurso));
        }
    }
}

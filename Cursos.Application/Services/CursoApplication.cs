using AutoMapper;
using Cursos.Application.Intefaces;
using Cursos.Application.ViewModel;
using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cursos.Application.Services
{
    public class CursoApplication : ICursoApplication
    {
        private readonly ICursoService _cursoService;
        private readonly IMapper _mapper;
        public CursoApplication(ICursoService cursoService, IMapper mapper)
        {
            _cursoService = cursoService;
            _mapper = mapper;
        }
        public void Add(CursoViewModel curso)
        {
            _cursoService.Add(_mapper.Map<Curso>(curso));
        }

        public CursoViewModel Find(Guid id)
        {
            var curso = _cursoService.Find(id);
            return _mapper.Map<CursoViewModel>(curso);
        }

        public IEnumerable<CursoViewModel> List()
        {
            var cursos = _cursoService.List();
            return _mapper.Map<IEnumerable<CursoViewModel>>(cursos);
        }

        public void Remove(Guid id)
        {
            _cursoService.Remove(id);
        }

        public void Update(CursoViewModel curso)
        {
            _cursoService.Update(_mapper.Map<Curso>(curso));
        }
    }
}

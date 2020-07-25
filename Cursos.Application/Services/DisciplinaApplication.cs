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
    public class DisciplinaApplication : IDisciplinaApplication
    {
        private readonly IDisciplicaService _disciplinaService;
        private readonly IMapper _mapper;
        public DisciplinaApplication(IDisciplicaService disciplinaService, IMapper mapper)
        {
            _disciplinaService = disciplinaService;
            _mapper = mapper;
        }
        public void Add(DisciplinaViewModel disciplina)
        {
            _disciplinaService.Add(_mapper.Map<Disciplina>(disciplina));
        }

        public DisciplinaViewModel Find(Guid id)
        {
            var disciplina = _disciplinaService.Find(id);
            return _mapper.Map<DisciplinaViewModel>(disciplina);
        }

        public IEnumerable<DisciplinaViewModel> List()
        {
            var disciplinas = _disciplinaService.List();
            return _mapper.Map<IEnumerable<DisciplinaViewModel>>(disciplinas);
        }

        public void Remove(DisciplinaViewModel disciplina)
        {
            _disciplinaService.Remove(_mapper.Map<Disciplina>(disciplina));
        }

        public void Update(DisciplinaViewModel disciplina)
        {
            _disciplinaService.Update(_mapper.Map<Disciplina>(disciplina));
        }
    }
}

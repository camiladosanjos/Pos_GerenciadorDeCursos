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
    public class InstituicaoApplication : IInstituicaoApplication
    {
        private readonly IInstituicaoService _instituicaoService;
        private readonly IMapper _mapper;
        public InstituicaoApplication(IInstituicaoService instituicaoService, IMapper mapper)
        {
            _instituicaoService = instituicaoService;
            _mapper = mapper;
        }
        public void Add(InstituicaoViewModel instituicao)
        {
            _instituicaoService.Add(_mapper.Map<Instituicao>(instituicao));
        }

        public InstituicaoViewModel Find(Guid id)
        {
            var instituicao = _instituicaoService.Find(id);
            return _mapper.Map<InstituicaoViewModel>(instituicao); ;
        }

        public IEnumerable<InstituicaoViewModel> List()
        {
            var instituicoes = _instituicaoService.List();
            return _mapper.Map<IEnumerable<InstituicaoViewModel>>(instituicoes);
        }

        public void Remove(Guid id)
        {
            _instituicaoService.Remove(id);
        }

        public void Update(InstituicaoViewModel instituicao)
        {
            _instituicaoService.Update(_mapper.Map<Instituicao>(instituicao));
        }
    }
}

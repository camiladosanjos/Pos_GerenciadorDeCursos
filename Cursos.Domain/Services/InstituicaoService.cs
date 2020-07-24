using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Domain.Services
{
    public class InstituicaoService : BaseService<Instituicao>, IInstituicaoService
    {
        private readonly IInstituicaoRepository _instituicaoRepository;
        public InstituicaoService(IInstituicaoRepository instituicaoRepository) : base(instituicaoRepository)
        {
            _instituicaoRepository = instituicaoRepository;
        }
    }
}

using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Infra.Data.Config;

namespace Cursos.Infra.Data.Repositories
{
    public class InstituicaoRepository : Repository<Instituicao>, IInstituicaoRepository
    {
        public CursosDbContext _context;
        public InstituicaoRepository(CursosDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

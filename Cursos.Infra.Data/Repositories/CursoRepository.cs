using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Infra.Data.Config;

namespace Cursos.Infra.Data.Repositories
{
    public class CursoRepository : Repository<Curso>, ICursoRepository
    {
        public CursosDbContext _context;
        public CursoRepository(CursosDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Infra.Data.Config;

namespace Cursos.Infra.Data.Repositories
{
    public class DisciplicaRepository : Repository<Disciplina>, IDisciplicaRepository
    {
        public CursosDbContext _context;
        public DisciplicaRepository(CursosDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

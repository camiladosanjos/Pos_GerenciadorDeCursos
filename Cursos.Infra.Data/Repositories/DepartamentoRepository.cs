using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Infra.Data.Config;

namespace Cursos.Infra.Data.Repositories
{
    public class DepartamentoRepository : Repository<Departamento>, IDepartamentoRepository
    {
        public CursosDbContext _context;
        public DepartamentoRepository(CursosDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

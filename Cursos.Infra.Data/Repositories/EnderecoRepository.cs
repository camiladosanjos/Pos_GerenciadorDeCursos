using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Infra.Data.Config;

namespace Cursos.Infra.Data.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public CursosDbContext _context;
        public EnderecoRepository(CursosDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

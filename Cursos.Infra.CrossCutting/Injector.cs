using Cursos.Domain.Entities;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Domain.Interfaces.Services;
using Cursos.Domain.Services;
using Cursos.Infra.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cursos.Infra.CrossCutting
{
    public class Injector
    {

        public static void RegisterContext(IServiceCollection services, IConfiguration configuration)
        {

        }

        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<BaseService<Curso>, BaseService<Curso>>();
            services.AddScoped<BaseService<Departamento>, BaseService<Departamento>>();
            services.AddScoped<BaseService<Disciplina>, BaseService<Disciplina>>();
            services.AddScoped<ICursoService, CursoService>();
            services.AddScoped<IDepartamentoService, DepartamentoService>();
            services.AddScoped<IDisciplicaService, DisciplicaService>();
        }

        public static void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Curso>, IBaseRepository<Curso>>();
            services.AddScoped<IBaseRepository<Departamento>, IBaseRepository<Departamento>>();
            services.AddScoped<IBaseRepository<Disciplina>, IBaseRepository<Disciplina>>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
            services.AddScoped<IDisciplicaRepository, DisciplicaRepository>();
        }

        public static void RegisterOptions(IServiceCollection services, IConfiguration configuration)
        {
        }
    }
}

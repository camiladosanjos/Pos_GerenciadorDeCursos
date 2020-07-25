using Autofac;
using Cursos.Application.Intefaces;
using Cursos.Application.Services;
using Cursos.Domain.Interfaces.Repositories;
using Cursos.Domain.Interfaces.Services;
using Cursos.Domain.Services;
using Cursos.Infra.Data.Repositories;
using System;

namespace Cursos.Infra.CrossCutting
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {

            #region IOC Application
            builder.RegisterType<CursoApplication>().As<ICursoApplication>();
            builder.RegisterType<InstituicaoApplication>().As<IInstituicaoApplication>();
            builder.RegisterType<DepartamentoApplication>().As<IDepartamentoApplication>();
            builder.RegisterType<DisciplinaApplication>().As<IDisciplinaApplication>();
            builder.RegisterType<EnderecoApplication>().As<IEnderecoApplication>();
            #endregion

            #region IOC Services
            builder.RegisterType<CursoService>().As<ICursoService>();
            builder.RegisterType<EnderecoService>().As<IEnderecoService>();
            builder.RegisterType<DepartamentoService>().As<IDepartamentoService>();
            builder.RegisterType<DisciplicaService>().As<IDisciplicaService>();
            builder.RegisterType<InstituicaoService>().As<IInstituicaoService>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<CursoRepository>().As<ICursoRepository>();
            builder.RegisterType<EnderecoRepository>().As<IEnderecoRepository>();
            builder.RegisterType<DepartamentoRepository>().As<IDepartamentoRepository>();
            builder.RegisterType<DisciplicaRepository>().As<IDisciplicaRepository>();
            builder.RegisterType<InstituicaoRepository>().As<IInstituicaoRepository>();
            #endregion

        }
    }
}

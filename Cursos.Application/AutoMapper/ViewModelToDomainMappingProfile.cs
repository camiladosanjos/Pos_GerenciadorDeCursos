using AutoMapper;
using Cursos.Application.ViewModel;
using Cursos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CursoViewModel, Curso>()
                .ForMember(dest => dest.Departamento, opt => opt.MapFrom(src => src.Departamento))
                .ForMember(dest => dest.ListDisciplinas, opt => opt.MapFrom(src => src.ListDisciplinas))
                .ReverseMap();
            CreateMap<DepartamentoViewModel, Departamento>()
                .ForMember(dest => dest.Instituicao, opt => opt.MapFrom(src => src.Instituicao))
                .ForMember(dest => dest.ListCursos, opt => opt.MapFrom(src => src.ListCursos))
                .ReverseMap();
            CreateMap<DetalhamentoCursoViewModel, DetalhamentoCurso>()
                .ForMember(dest => dest.Curso, opt => opt.MapFrom(src => src.Curso))
                .ForMember(dest => dest.Disciplina, opt => opt.MapFrom(src => src.Disciplina))
                .ReverseMap();
            CreateMap<DisciplinaViewModel, Disciplina>()
                .ForMember(dest => dest.ListCursos, opt => opt.MapFrom(src => src.ListCursos))
                .ReverseMap();
            CreateMap<EnderecoViewModel, Endereco>()
                .ForMember(dest => dest.Instituicao, opt => opt.MapFrom(src => src.Instituicao))
                .ReverseMap();
            CreateMap<InstituicaoViewModel, Instituicao>()
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.ListDepartamentos, opt => opt.MapFrom(src => src.ListDepartamentos))
                .ReverseMap();
        }
    }
}

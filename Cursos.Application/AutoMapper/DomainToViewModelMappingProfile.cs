using AutoMapper;
using Cursos.Application.ViewModel;
using Cursos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursos.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Curso, CursoViewModel>()
                .ForMember(dest => dest.Departamento, opt => opt.MapFrom(src => src.Departamento))
                .ForMember(dest => dest.Disciplina, opt => opt.MapFrom(src => src.Disciplina))
                .ReverseMap();
            CreateMap<Departamento, DepartamentoViewModel>()
                .ForMember(dest => dest.Instituicao, opt => opt.MapFrom(src => src.Instituicao))
                .ForMember(dest => dest.Cursos, opt => opt.MapFrom(src => src.Cursos))
                .ReverseMap();
            CreateMap<DetalhamentoCurso, DetalhamentoCursoViewModel>()
                .ForMember(dest => dest.CursoDisciplina, opt => opt.MapFrom(src => src.CursoDisciplina))
                .ForMember(dest => dest.DisciplinaCurso, opt => opt.MapFrom(src => src.DisciplinaCurso))
                .ReverseMap();
            CreateMap<Disciplina, DisciplinaViewModel>()
                .ForMember(dest => dest.Cursos, opt => opt.MapFrom(src => src.Cursos))
                .ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>()
                .ForMember(dest => dest.Instituicao, opt => opt.MapFrom(src => src.Instituicao))
                .ReverseMap();
            CreateMap<Instituicao, InstituicaoViewModel>()
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.Departamentos, opt => opt.MapFrom(src => src.Departamentos))
                .ReverseMap();
        }
    }

}
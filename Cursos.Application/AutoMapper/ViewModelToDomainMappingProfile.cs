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
                .ForMember(dest => dest.Disciplina, opt => opt.MapFrom(src => src.Disciplina))
                .ReverseMap();
            CreateMap<DepartamentoViewModel, Departamento>()
                .ForMember(dest => dest.Instituicao, opt => opt.MapFrom(src => src.Instituicao))
                .ForMember(dest => dest.Cursos, opt => opt.MapFrom(src => src.Cursos))
                .ReverseMap();
            CreateMap<DetalhamentoCursoViewModel, DetalhamentoCurso>()
                .ForMember(dest => dest.CursoDisciplina, opt => opt.MapFrom(src => src.CursoDisciplina))
                .ForMember(dest => dest.DisciplinaCurso, opt => opt.MapFrom(src => src.DisciplinaCurso))
                .ReverseMap();
            CreateMap<DisciplinaViewModel, Disciplina>()
                .ForMember(dest => dest.Cursos, opt => opt.MapFrom(src => src.Cursos))
                .ReverseMap();
            CreateMap<EnderecoViewModel, Endereco>()
                .ForMember(dest => dest.Instituicao, opt => opt.MapFrom(src => src.Instituicao))
                .ReverseMap();
            CreateMap<InstituicaoViewModel, Instituicao>()
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.Departamentos, opt => opt.MapFrom(src => src.Departamentos))
                .ReverseMap();
        }
    }
}

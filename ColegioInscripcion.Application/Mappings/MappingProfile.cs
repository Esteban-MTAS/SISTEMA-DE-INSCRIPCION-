using AutoMapper;
using ColegioInscripcion.Application.DTOs;
using ColegioInscripcion.Domain.Entities;

namespace ColegioInscripcion.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<NivelEducativo, NivelEducativoDto>();

        CreateMap<Grado, GradoDto>()
            .ForMember(d => d.NivelNombre, o => o.MapFrom(s => s.NivelEducativo != null ? s.NivelEducativo.Nombre : null));

        CreateMap<Seccion, SeccionDto>()
            .ForMember(d => d.GradoNombre, o => o.MapFrom(s => s.Grado.Nombre))
            .ForMember(d => d.PeriodoNombre, o => o.MapFrom(s => s.PeriodoEscolar.Nombre));

        CreateMap<AreaTecnica, AreaTecnicaDto>();

        CreateMap<OfertaTecnica, OfertaTecnicaDto>()
            .ForMember(d => d.PeriodoNombre, o => o.MapFrom(s => s.PeriodoEscolar.Nombre))
            .ForMember(d => d.GradoNombre, o => o.MapFrom(s => s.Grado.Nombre))
            .ForMember(d => d.AreaNombre, o => o.MapFrom(s => s.AreaTecnica.Nombre));
    }
}

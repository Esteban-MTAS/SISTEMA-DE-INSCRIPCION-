using ColegioInscripcion.Application.DTOs;

namespace ColegioInscripcion.Application.Interfaces;

public interface ICatalogosService
{
    Task<List<NivelEducativoDto>> GetNivelesAsync();
    Task<List<GradoDto>> GetGradosAsync(int? nivelId);
    Task<List<SeccionDto>> GetSeccionesAsync(int periodoId, int? gradoId);
    Task<List<AreaTecnicaDto>> GetAreasTecnicasAsync();
    Task<List<OfertaTecnicaDto>> GetOfertasTecnicasAsync(int periodoId, int? gradoId);
}

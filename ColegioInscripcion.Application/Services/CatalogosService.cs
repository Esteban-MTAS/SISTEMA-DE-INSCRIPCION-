using AutoMapper;
using ColegioInscripcion.Application.DTOs;
using ColegioInscripcion.Application.Interfaces;
using ColegioInscripcion.Domain.Interfaces;

namespace ColegioInscripcion.Application.Services;

public class CatalogosService : ICatalogosService
{
    private readonly INivelEducativoRepository _nivelRepo;
    private readonly IGradoRepository _gradoRepo;
    private readonly ISeccionRepository _seccionRepo;
    private readonly IAreaTecnicaRepository _areaRepo;
    private readonly IOfertaTecnicaRepository _ofertaRepo;
    private readonly IMapper _mapper;

    public CatalogosService(
        INivelEducativoRepository nivelRepo,
        IGradoRepository gradoRepo,
        ISeccionRepository seccionRepo,
        IAreaTecnicaRepository areaRepo,
        IOfertaTecnicaRepository ofertaRepo,
        IMapper mapper)
    {
        _nivelRepo = nivelRepo;
        _gradoRepo = gradoRepo;
        _seccionRepo = seccionRepo;
        _areaRepo = areaRepo;
        _ofertaRepo = ofertaRepo;
        _mapper = mapper;
    }

    public async Task<List<NivelEducativoDto>> GetNivelesAsync()
        => _mapper.Map<List<NivelEducativoDto>>(await _nivelRepo.GetAllAsync());

    public async Task<List<GradoDto>> GetGradosAsync(int? nivelId)
    {
        var grados = nivelId.HasValue
            ? await _gradoRepo.GetByNivelAsync(nivelId.Value)
            : await _gradoRepo.GetAllAsync();

        return _mapper.Map<List<GradoDto>>(grados);
    }

    public async Task<List<SeccionDto>> GetSeccionesAsync(int periodoId, int? gradoId)
    {
        var secciones = gradoId.HasValue
            ? await _seccionRepo.GetByPeriodoYGradoAsync(periodoId, gradoId.Value)
            : await _seccionRepo.GetByPeriodoAsync(periodoId);

        return _mapper.Map<List<SeccionDto>>(secciones);
    }

    public async Task<List<AreaTecnicaDto>> GetAreasTecnicasAsync()
        => _mapper.Map<List<AreaTecnicaDto>>(await _areaRepo.GetAllAsync());

    public async Task<List<OfertaTecnicaDto>> GetOfertasTecnicasAsync(int periodoId, int? gradoId)
    {
        var ofertas = gradoId.HasValue
            ? await _ofertaRepo.GetByPeriodoYGradoAsync(periodoId, gradoId.Value)
            : await _ofertaRepo.GetByPeriodoAsync(periodoId);

        return _mapper.Map<List<OfertaTecnicaDto>>(ofertas);
    }
}

using ColegioInscripcion.Application.Interfaces;
using ColegioInscripcion.Domain.Entities;
using ColegioInscripcion.Domain.Interfaces;

namespace ColegioInscripcion.Application.Services;

public class PeriodoEscolarService : IPeriodoEscolarService
{
    private readonly IPeriodoEscolarRepository _repository;

    public PeriodoEscolarService(IPeriodoEscolarRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<PeriodoEscolar>> ObtenerTodosAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<PeriodoEscolar?> ObtenerActivoAsync()
    {
        return await _repository.GetActivoAsync();
    }
}

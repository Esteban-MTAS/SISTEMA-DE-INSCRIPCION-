using ColegioInscripcion.Domain.Entities;

namespace ColegioInscripcion.Domain.Interfaces;

public interface IPeriodoEscolarRepository
{
    Task<List<PeriodoEscolar>> GetAllAsync();
    Task<PeriodoEscolar?> GetActivoAsync();
}

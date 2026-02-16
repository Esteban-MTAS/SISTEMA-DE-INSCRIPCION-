using ColegioInscripcion.Domain.Entities;

namespace ColegioInscripcion.Domain.Interfaces;

public interface INivelEducativoRepository
{
    Task<List<NivelEducativo>> GetAllAsync();
}

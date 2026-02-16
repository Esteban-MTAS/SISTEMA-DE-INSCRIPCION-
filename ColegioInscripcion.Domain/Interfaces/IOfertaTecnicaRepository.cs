using ColegioInscripcion.Domain.Entities;

namespace ColegioInscripcion.Domain.Interfaces;

public interface IOfertaTecnicaRepository
{
    Task<List<OfertaTecnica>> GetByPeriodoAsync(int periodoId);
    Task<List<OfertaTecnica>> GetByPeriodoYGradoAsync(int periodoId, int gradoId);
}

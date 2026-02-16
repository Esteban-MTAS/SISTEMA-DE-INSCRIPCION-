using ColegioInscripcion.Domain.Entities;

namespace ColegioInscripcion.Domain.Interfaces;

public interface ISeccionRepository
{
    Task<List<Seccion>> GetByPeriodoAsync(int periodoId);
    Task<List<Seccion>> GetByPeriodoYGradoAsync(int periodoId, int gradoId);
}

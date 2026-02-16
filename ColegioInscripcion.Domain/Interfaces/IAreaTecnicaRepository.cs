using ColegioInscripcion.Domain.Entities;

namespace ColegioInscripcion.Domain.Interfaces;

public interface IAreaTecnicaRepository
{
    Task<List<AreaTecnica>> GetAllAsync();
}

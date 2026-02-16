using ColegioInscripcion.Domain.Entities;

namespace ColegioInscripcion.Domain.Interfaces;

public interface IGradoRepository
{
    Task<List<Grado>> GetAllAsync();
    Task<List<Grado>> GetByNivelAsync(int nivelId);
}

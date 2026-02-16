using ColegioInscripcion.Domain.Entities;
using ColegioInscripcion.Domain.Interfaces;
using ColegioInscripcion.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ColegioInscripcion.Infrastructure.Repositories;

public class GradoRepository : IGradoRepository
{
    private readonly AppDbContext _db;
    public GradoRepository(AppDbContext db) => _db = db;

    public async Task<List<Grado>> GetAllAsync()
    {
        return await _db.Grados
            .Include(x => x.NivelEducativo)
            .OrderBy(x => x.Orden)
            .ToListAsync();
    }

    public async Task<List<Grado>> GetByNivelAsync(int nivelId)
    {
        return await _db.Grados
            .Include(x => x.NivelEducativo)
            .Where(x => x.NivelEducativoId == nivelId)
            .OrderBy(x => x.Orden)
            .ToListAsync();
    }
}

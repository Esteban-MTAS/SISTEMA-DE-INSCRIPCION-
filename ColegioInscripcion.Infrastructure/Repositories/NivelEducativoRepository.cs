using ColegioInscripcion.Domain.Entities;
using ColegioInscripcion.Domain.Interfaces;
using ColegioInscripcion.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ColegioInscripcion.Infrastructure.Repositories;

public class NivelEducativoRepository : INivelEducativoRepository
{
    private readonly AppDbContext _db;
    public NivelEducativoRepository(AppDbContext db) => _db = db;

    public async Task<List<NivelEducativo>> GetAllAsync()
    {
        return await _db.NivelesEducativos
            .OrderBy(x => x.Orden)
            .ToListAsync();
    }
}

using ColegioInscripcion.Domain.Entities;
using ColegioInscripcion.Domain.Interfaces;
using ColegioInscripcion.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ColegioInscripcion.Infrastructure.Repositories;

public class AreaTecnicaRepository : IAreaTecnicaRepository
{
    private readonly AppDbContext _db;
    public AreaTecnicaRepository(AppDbContext db) => _db = db;

    public async Task<List<AreaTecnica>> GetAllAsync()
    {
        return await _db.AreasTecnicas
            .OrderBy(x => x.Nombre)
            .ToListAsync();
    }
}

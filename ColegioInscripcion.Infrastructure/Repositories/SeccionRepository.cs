using ColegioInscripcion.Domain.Entities;
using ColegioInscripcion.Domain.Interfaces;
using ColegioInscripcion.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ColegioInscripcion.Infrastructure.Repositories;

public class SeccionRepository : ISeccionRepository
{
    private readonly AppDbContext _db;
    public SeccionRepository(AppDbContext db) => _db = db;

    public async Task<List<Seccion>> GetByPeriodoAsync(int periodoId)
    {
        return await _db.Secciones
            .Include(x => x.Grado)
            .Include(x => x.PeriodoEscolar)
            .Where(x => x.PeriodoEscolarId == periodoId)
            .OrderBy(x => x.Grado.Orden)
            .ThenBy(x => x.Nombre)
            .ToListAsync();
    }

    public async Task<List<Seccion>> GetByPeriodoYGradoAsync(int periodoId, int gradoId)
    {
        return await _db.Secciones
            .Include(x => x.Grado)
            .Include(x => x.PeriodoEscolar)
            .Where(x => x.PeriodoEscolarId == periodoId && x.GradoId == gradoId)
            .OrderBy(x => x.Nombre)
            .ToListAsync();
    }
}

using ColegioInscripcion.Domain.Entities;
using ColegioInscripcion.Domain.Interfaces;
using ColegioInscripcion.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ColegioInscripcion.Infrastructure.Repositories;

public class OfertaTecnicaRepository : IOfertaTecnicaRepository
{
    private readonly AppDbContext _db;
    public OfertaTecnicaRepository(AppDbContext db) => _db = db;

    public async Task<List<OfertaTecnica>> GetByPeriodoAsync(int periodoId)
    {
        return await _db.OfertasTecnicas
            .Include(x => x.PeriodoEscolar)
            .Include(x => x.Grado)
            .Include(x => x.AreaTecnica)
            .Where(x => x.PeriodoEscolarId == periodoId)
            .OrderBy(x => x.Grado.Orden)
            .ThenBy(x => x.AreaTecnica.Nombre)
            .ToListAsync();
    }

    public async Task<List<OfertaTecnica>> GetByPeriodoYGradoAsync(int periodoId, int gradoId)
    {
        return await _db.OfertasTecnicas
            .Include(x => x.PeriodoEscolar)
            .Include(x => x.Grado)
            .Include(x => x.AreaTecnica)
            .Where(x => x.PeriodoEscolarId == periodoId && x.GradoId == gradoId)
            .OrderBy(x => x.AreaTecnica.Nombre)
            .ToListAsync();
    }
}

using ColegioInscripcion.Domain.Entities;
using ColegioInscripcion.Domain.Interfaces;
using ColegioInscripcion.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ColegioInscripcion.Infrastructure.Repositories;

public class PeriodoEscolarRepository : IPeriodoEscolarRepository
{
    private readonly AppDbContext _context;

    public PeriodoEscolarRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PeriodoEscolar>> GetAllAsync()
    {
        return await _context.PeriodosEscolares
            .OrderByDescending(x => x.Activo)
            .ThenByDescending(x => x.FechaInicio)
            .ToListAsync();
    }

    public async Task<PeriodoEscolar?> GetActivoAsync()
    {
        return await _context.PeriodosEscolares
            .FirstOrDefaultAsync(x => x.Activo);
    }
}

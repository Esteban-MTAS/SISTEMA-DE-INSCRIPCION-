using ColegioInscripcion.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ColegioInscripcion.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    private readonly AppDbContext _db;

    public HealthController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var canConnect = await _db.Database.CanConnectAsync();
        return Ok(new
        {
            status = "ok",
            database = canConnect ? "connected" : "not-connected"
        });
    }

    [HttpGet("periodos")]
    public async Task<IActionResult> GetPeriodos()
    {
        var data = await _db.PeriodosEscolares
            .OrderByDescending(x => x.Activo)
            .ThenByDescending(x => x.FechaInicio)
            .Select(x => new { x.Id, x.Nombre, x.Activo, x.FechaInicio, x.FechaFin })
            .ToListAsync();

        return Ok(data);
    }
}

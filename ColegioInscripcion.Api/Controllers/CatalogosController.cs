using ColegioInscripcion.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ColegioInscripcion.Api.Controllers;

[ApiController]
[Route("api/catalogos")]
public class CatalogosController : ControllerBase
{
    private readonly ICatalogosService _service;

    public CatalogosController(ICatalogosService service)
    {
        _service = service;
    }

    [HttpGet("niveles")]
    public async Task<IActionResult> Niveles()
        => Ok(await _service.GetNivelesAsync());

    [HttpGet("grados")]
    public async Task<IActionResult> Grados([FromQuery] int? nivelId)
        => Ok(await _service.GetGradosAsync(nivelId));

    [HttpGet("secciones")]
    public async Task<IActionResult> Secciones([FromQuery] int periodoId, [FromQuery] int? gradoId)
        => Ok(await _service.GetSeccionesAsync(periodoId, gradoId));

    [HttpGet("areas-tecnicas")]
    public async Task<IActionResult> AreasTecnicas()
        => Ok(await _service.GetAreasTecnicasAsync());

    [HttpGet("ofertas-tecnicas")]
    public async Task<IActionResult> OfertasTecnicas([FromQuery] int periodoId, [FromQuery] int? gradoId)
        => Ok(await _service.GetOfertasTecnicasAsync(periodoId, gradoId));
}

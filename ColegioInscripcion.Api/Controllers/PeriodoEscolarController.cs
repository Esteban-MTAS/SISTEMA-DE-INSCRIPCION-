using ColegioInscripcion.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ColegioInscripcion.Api.Controllers;

[ApiController]
[Route("api/periodos-escolares")]
public class PeriodoEscolarController : ControllerBase
{
    private readonly IPeriodoEscolarService _service;

    public PeriodoEscolarController(IPeriodoEscolarService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await _service.ObtenerTodosAsync();
        return Ok(data);
    }

    [HttpGet("activo")]
    public async Task<IActionResult> GetActivo()
    {
        var data = await _service.ObtenerActivoAsync();
        if (data == null) return NotFound();
        return Ok(data);
    }
}

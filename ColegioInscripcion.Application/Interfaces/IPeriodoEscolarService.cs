using System;
using System.Collections.Generic;
using ColegioInscripcion.Domain.Entities;

namespace ColegioInscripcion.Application.Interfaces;

public interface IPeriodoEscolarService
{
    Task<List<PeriodoEscolar>> ObtenerTodosAsync();
    Task<PeriodoEscolar?> ObtenerActivoAsync();
}

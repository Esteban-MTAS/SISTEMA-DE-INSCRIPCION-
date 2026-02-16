namespace ColegioInscripcion.Application.DTOs;

public class OfertaTecnicaDto
{
    public int Id { get; set; }

    public int PeriodoEscolarId { get; set; }
    public string PeriodoNombre { get; set; } = null!;

    public int GradoId { get; set; }
    public string GradoNombre { get; set; } = null!;

    public int AreaTecnicaId { get; set; }
    public string AreaNombre { get; set; } = null!;

    public int CupoMaximo { get; set; }
    public bool Activo { get; set; }
}

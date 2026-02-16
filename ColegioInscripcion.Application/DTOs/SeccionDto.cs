namespace ColegioInscripcion.Application.DTOs;

public class SeccionDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public int CupoMaximo { get; set; }
    public bool Activo { get; set; }

    public int GradoId { get; set; }
    public string GradoNombre { get; set; } = null!;

    public int PeriodoEscolarId { get; set; }
    public string PeriodoNombre { get; set; } = null!;

    public string Modalidad { get; set; } = null!;
}

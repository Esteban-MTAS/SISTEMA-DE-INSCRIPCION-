namespace ColegioInscripcion.Application.DTOs;

public class AreaTecnicaDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string? Codigo { get; set; }
    public bool Activo { get; set; }
}

namespace ColegioInscripcion.Application.DTOs;

public class GradoDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public int Orden { get; set; }
    public bool Activo { get; set; }

    public int? NivelEducativoId { get; set; }
    public string? NivelNombre { get; set; }

    public string? Codigo { get; set; }
    public int? EdadMin { get; set; }
    public int? EdadMax { get; set; }
}

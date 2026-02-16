namespace ColegioInscripcion.Application.DTOs;

public class NivelEducativoDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public int Orden { get; set; }
    public bool Activo { get; set; }
}

namespace ColegioInscripcion.Domain.Entities;

public class AreaTecnica
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string? Codigo { get; set; }
    public bool Activo { get; set; }

    public ICollection<OfertaTecnica> Ofertas { get; set; } = new List<OfertaTecnica>();
}

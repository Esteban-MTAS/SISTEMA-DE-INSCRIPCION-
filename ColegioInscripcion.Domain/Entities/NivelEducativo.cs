namespace ColegioInscripcion.Domain.Entities;

public class NivelEducativo
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public int Orden { get; set; }
    public bool Activo { get; set; }

    public ICollection<Grado> Grados { get; set; } = new List<Grado>();
}

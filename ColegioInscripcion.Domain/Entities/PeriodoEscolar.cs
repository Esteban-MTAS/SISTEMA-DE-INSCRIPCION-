namespace ColegioInscripcion.Domain.Entities;

public class PeriodoEscolar
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; }

    public ICollection<Seccion> Secciones { get; set; } = new List<Seccion>();
}

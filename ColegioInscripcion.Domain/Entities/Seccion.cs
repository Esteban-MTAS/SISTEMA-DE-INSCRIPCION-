namespace ColegioInscripcion.Domain.Entities;

public class Seccion
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public int CupoMaximo { get; set; }
    public int GradoId { get; set; }
    public int PeriodoEscolarId { get; set; }
    public bool Activo { get; set; }

    public string Modalidad { get; set; } = "Academica";

    public Grado Grado { get; set; } = null!;
    public PeriodoEscolar PeriodoEscolar { get; set; } = null!;
}

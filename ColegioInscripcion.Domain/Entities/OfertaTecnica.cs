namespace ColegioInscripcion.Domain.Entities;

public class OfertaTecnica
{
    public int Id { get; set; }
    public int PeriodoEscolarId { get; set; }
    public int GradoId { get; set; }
    public int AreaTecnicaId { get; set; }
    public int CupoMaximo { get; set; }
    public bool Activo { get; set; }

    public PeriodoEscolar PeriodoEscolar { get; set; } = null!;
    public Grado Grado { get; set; } = null!;
    public AreaTecnica AreaTecnica { get; set; } = null!;
}

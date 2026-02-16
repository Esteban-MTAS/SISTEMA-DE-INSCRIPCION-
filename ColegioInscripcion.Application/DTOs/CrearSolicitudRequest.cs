namespace ColegioInscripcion.Application.DTOs;

public class CrearSolicitudRequest
{
    // Tutor
    public string TutorNombres { get; set; } = null!;
    public string TutorApellidos { get; set; } = null!;
    public string TutorCedula { get; set; } = null!;
    public string TutorTelefono { get; set; } = null!;
    public string TutorEmail { get; set; } = null!;
    public string TutorDireccion { get; set; } = null!;

    // Estudiante
    public string EstudianteNombres { get; set; } = null!;
    public string EstudianteApellidos { get; set; } = null!;
    public DateTime EstudianteFechaNacimiento { get; set; }
    public string EstudianteSexo { get; set; } = null!; // M/F/O

    // Inscripción
    public int PeriodoEscolarId { get; set; }
    public int SeccionId { get; set; }

    // Solo si aplica politécnico
    public int? OfertaTecnicaId { get; set; }
}

using ColegioInscripcion.Application.DTOs;
using FluentValidation;

namespace ColegioInscripcion.Application.Validators;

public class CrearSolicitudRequestValidator : AbstractValidator<CrearSolicitudRequest>
{
    public CrearSolicitudRequestValidator()
    {
        RuleFor(x => x.TutorNombres).NotEmpty().MaximumLength(80);
        RuleFor(x => x.TutorApellidos).NotEmpty().MaximumLength(80);
        RuleFor(x => x.TutorCedula).NotEmpty().MaximumLength(20);
        RuleFor(x => x.TutorTelefono).NotEmpty().MaximumLength(30);
        RuleFor(x => x.TutorEmail).NotEmpty().EmailAddress().MaximumLength(120);
        RuleFor(x => x.TutorDireccion).NotEmpty().MaximumLength(200);

        RuleFor(x => x.EstudianteNombres).NotEmpty().MaximumLength(80);
        RuleFor(x => x.EstudianteApellidos).NotEmpty().MaximumLength(80);
        RuleFor(x => x.EstudianteFechaNacimiento).NotEmpty();
        RuleFor(x => x.EstudianteSexo)
            .NotEmpty()
            .Must(s => s is "M" or "F" or "O")
            .WithMessage("Sexo debe ser M, F u O.");

        RuleFor(x => x.PeriodoEscolarId).GreaterThan(0);
        RuleFor(x => x.SeccionId).GreaterThan(0);
    }
}

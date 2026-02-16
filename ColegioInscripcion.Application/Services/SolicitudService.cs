using FluentValidation;
using ColegioInscripcion.Application.DTOs;

public class SolicitudService
{
    private readonly IValidator<CrearSolicitudRequest> _validator;

    public SolicitudService(IValidator<CrearSolicitudRequest> validator)
    {
        _validator = validator;
    }

    public async Task CrearAsync(CrearSolicitudRequest request)
    {
        var result = await _validator.ValidateAsync(request);

        if (!result.IsValid)
            throw new ValidationException(result.Errors);

        // aquí va la lógica real de inscripción
    }
}

using ColegioInscripcion.Application.Interfaces;
using ColegioInscripcion.Application.Services;
using ColegioInscripcion.Domain.Interfaces;
using ColegioInscripcion.Infrastructure.Repositories;


namespace ColegioInscripcion.Api.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Repos
        services.AddScoped<INivelEducativoRepository, NivelEducativoRepository>();
        services.AddScoped<IGradoRepository, GradoRepository>();
        services.AddScoped<ISeccionRepository, SeccionRepository>();
        services.AddScoped<IAreaTecnicaRepository, AreaTecnicaRepository>();
        services.AddScoped<IOfertaTecnicaRepository, OfertaTecnicaRepository>();
        services.AddScoped<SolicitudService>();


        // Services
        services.AddScoped<ICatalogosService, CatalogosService>();

        return services;
    }
}

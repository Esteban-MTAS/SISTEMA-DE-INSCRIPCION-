using ColegioInscripcion.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using ColegioInscripcion.Api.Extensions;
using ColegioInscripcion.Application.Mappings;
using ColegioInscripcion.Application.Validators;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();



// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// AutoMapper
builder.Services.AddAutoMapper(typeof(ColegioInscripcion.Application.Mappings.MappingProfile).Assembly);

builder.Services.AddValidatorsFromAssemblyContaining<CrearSolicitudRequestValidator>();

var app = builder.Build();

// Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

// (Por ahora no hemos configurado Auth, pero no hace daño dejarlo)
// app.UseAuthorization();

app.MapControllers();

app.Run();

# Modelo de datos (BD v1) - Sistema de Inscripción

## Base de datos
- Nombre: ColegioInscripcionDb
- Esquema: core

## Tablas
- core.PeriodoEscolar
- core.Grado
- core.Seccion
- core.Tutor
- core.Estudiante
- core.SolicitudInscripcion
- core.DocumentoSolicitud
- core.SolicitudHistorialEstado

## Relaciones
- Grado 1..* Seccion
- PeriodoEscolar 1..* Seccion
- Tutor 1..* SolicitudInscripcion
- Estudiante 1..* SolicitudInscripcion
- Seccion 1..* SolicitudInscripcion
- SolicitudInscripcion 1..* DocumentoSolicitud
- SolicitudInscripcion 1..* SolicitudHistorialEstado

## Estados de solicitud
1 Pendiente, 2 EnRevision, 3 Aprobada, 4 Rechazada

## Reglas (constraints)
- PeriodoEscolar.Nombre único
- Grado.Nombre y Grado.Orden únicos
- Seccion única por (GradoId, PeriodoEscolarId, Nombre)
- Tutor.Cedula y Tutor.Email únicos
- Solicitud única por (PeriodoEscolarId, EstudianteId)
- CupoMaximo entre 1 y 60
- Sexo permitido: M/F/O

## Extensión Politécnico (Técnico-Profesional)
- core.AreaTecnica: catálogo de carreras (Informática, Electrónica, etc.)
- core.OfertaTecnica: define oferta por PeriodoEscolar + Grado + AreaTecnica con cupo
- core.SolicitudInscripcion.OfertaTecnicaId: opcional, si aplica modalidad técnica

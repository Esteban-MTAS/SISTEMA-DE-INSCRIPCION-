# Arquitectura y estructura del proyecto

## Solución
- ColegioInscripcion.sln

## Proyectos
### 1) ColegioInscripcion.Api
Responsable de exponer la API (Controllers), configuración de autenticación, Swagger/OpenAPI, middlewares.

Carpetas:
- Controllers: endpoints
- Contracts: request/response models (si aplica)
- Extensions: registro de servicios, swagger, auth
- Middlewares: manejo global de errores, logging, etc.

### 2) ColegioInscripcion.Application
Contiene la lógica de aplicación (casos de uso), DTOs, validaciones y mapeos.

Carpetas:
- DTOs
- Interfaces (servicios de aplicación)
- Services
- Validators
- Mappings

### 3) ColegioInscripcion.Domain
Modelo del dominio: entidades, enums e interfaces de repositorios (contratos).

Carpetas:
- Entities
- Enums
- Interfaces
- Common

### 4) ColegioInscripcion.Infrastructure
Implementación de persistencia (EF Core), repositorios, y (más adelante) Identity.

Carpetas:
- Persistence (DbContext, configuraciones EF)
- Repositories
- Migrations
- Identity

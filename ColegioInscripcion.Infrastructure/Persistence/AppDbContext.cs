using ColegioInscripcion.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ColegioInscripcion.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<NivelEducativo> NivelesEducativos => Set<NivelEducativo>();
    public DbSet<AreaTecnica> AreasTecnicas => Set<AreaTecnica>();
    public DbSet<OfertaTecnica> OfertasTecnicas => Set<OfertaTecnica>();

    public DbSet<PeriodoEscolar> PeriodosEscolares => Set<PeriodoEscolar>();
    public DbSet<Grado> Grados => Set<Grado>();
    public DbSet<Seccion> Secciones => Set<Seccion>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Esquema core
        modelBuilder.HasDefaultSchema("core");

        modelBuilder.Entity<PeriodoEscolar>(e =>
        {
            e.ToTable("PeriodoEscolar");
            e.HasKey(x => x.Id);
            e.Property(x => x.Nombre).HasMaxLength(30).IsRequired();
        });

        modelBuilder.Entity<Grado>(e =>
        {
            e.ToTable("Grado");
            e.HasKey(x => x.Id);
            e.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
        });

        modelBuilder.Entity<Seccion>(e =>
        {
            e.ToTable("Seccion");
            e.HasKey(x => x.Id);
            e.Property(x => x.Nombre).HasMaxLength(10).IsRequired();

            e.HasOne(x => x.Grado)
             .WithMany(g => g.Secciones)
             .HasForeignKey(x => x.GradoId);

            e.HasOne(x => x.PeriodoEscolar)
             .WithMany(p => p.Secciones)
             .HasForeignKey(x => x.PeriodoEscolarId);
        });

        modelBuilder.Entity<NivelEducativo>(e =>
        {
            e.ToTable("NivelEducativo");
            e.HasKey(x => x.Id);
            e.Property(x => x.Nombre).HasMaxLength(50).IsRequired();
        });

        modelBuilder.Entity<Grado>(e =>
        {
            e.ToTable("Grado");
            e.HasKey(x => x.Id);
            e.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            e.Property(x => x.Codigo).HasMaxLength(20);

            e.HasOne(x => x.NivelEducativo)
             .WithMany(n => n.Grados)
             .HasForeignKey(x => x.NivelEducativoId);
        });

        modelBuilder.Entity<Seccion>(e =>
        {
            e.ToTable("Seccion");
            e.HasKey(x => x.Id);
            e.Property(x => x.Nombre).HasMaxLength(10).IsRequired();
            e.Property(x => x.Modalidad).HasMaxLength(30).IsRequired();
        });

        modelBuilder.Entity<AreaTecnica>(e =>
        {
            e.ToTable("AreaTecnica");
            e.HasKey(x => x.Id);
            e.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            e.Property(x => x.Codigo).HasMaxLength(20);
        });

        modelBuilder.Entity<OfertaTecnica>(e =>
        {
            e.ToTable("OfertaTecnica");
            e.HasKey(x => x.Id);

            e.HasOne(x => x.PeriodoEscolar)
             .WithMany()
             .HasForeignKey(x => x.PeriodoEscolarId);

            e.HasOne(x => x.Grado)
             .WithMany()
             .HasForeignKey(x => x.GradoId);

            e.HasOne(x => x.AreaTecnica)
             .WithMany(a => a.Ofertas)
             .HasForeignKey(x => x.AreaTecnicaId);
        });

    }
}


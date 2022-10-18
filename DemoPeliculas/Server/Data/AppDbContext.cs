using DemoPeliculas.Server.Data.Seed;
using DemoPeliculas.Shared.Models;
using Microsoft.EntityFrameworkCore;


namespace DemoPeliculas.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

        public virtual DbSet<Pelicula> Peliculas { get; set; }
        public virtual DbSet<Puntuacion> Puntuaciones { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>()
                          .HasData(PeliculasSeed.Seed());

            modelBuilder.Entity<Usuario>()
              .HasData(UsuarioSeed.Seed());

        }

        public DbSet<DemoPeliculas.Shared.Models.ListaReproduccion> ListaReproduccion { get; set; }

    }
}
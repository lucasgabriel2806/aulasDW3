using ExercicioEventos.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Tipo> Tipos { get; set; }
    public DbSet<Patrocinador> Patrocinadores { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}
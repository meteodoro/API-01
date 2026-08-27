using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Infra;

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions options) : base (options)
    {
        
    }
    
    public DbSet<Livro> Livros => Set<Livro>();
    public DbSet<Genero> Generos => Set<Genero>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>()
            .HasOne(l => l.Genero)
            .WithMany(g => g.Livros)
            .HasForeignKey(l => l.GeneroId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
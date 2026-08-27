using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Infra;

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions options) : base (options)
    {
        
    }
    
    public DbSet<Livro> Livros => Set<Livro>();
}
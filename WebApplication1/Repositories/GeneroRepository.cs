using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Infra;

namespace WebApplication1.Repositories;

public class GeneroRepository : IGeneroRepository
{
    private readonly AppDbContext _context;
    
    public GeneroRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Genero>> ObterTodosAsync()
    {
        return await _context.Generos.ToListAsync();
    }

    public async Task<Genero?> ObterPorIdAsync(int id)
    {
        return await _context.Generos.FindAsync(id);
    }

    public Task AdicionarAsync(Genero genero)
    {
        _context.Generos.Add(genero);
        return _context.SaveChangesAsync();
    }
}
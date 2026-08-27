using Microsoft.EntityFrameworkCore;
using WebApplication1.Infra;
using WebApplication1.Models;

namespace WebApplication1.Repositories;

public class LivroRepository : ILivroRepository
{
    private readonly AppDbContext _context;
    
    public LivroRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Livro>> ObterTodosAsync()
    {
        return await _context.Livros.ToListAsync();
    }

    public async Task<Livro?> ObterPorIdAsync(int id)
    {
        return await _context.Livros.FindAsync(id);
    }

    public async Task AdicionarAsync(Livro livro)
    {
        _context.Livros.Add(livro);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Livro livro)
    {
        _context.Livros.Update(livro);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(Livro livro)
    {
        _context.Livros.Remove(livro);
        await _context.SaveChangesAsync();
    }
}
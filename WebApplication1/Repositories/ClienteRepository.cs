using Microsoft.EntityFrameworkCore;
using WebApplication1.DTOs;
using WebApplication1.Infra;
using WebApplication1.Models;

namespace WebApplication1.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _context;
    
    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Cliente>> ObterTodosAsync()
    {
        return await _context.Clientes.ToListAsync();
    }

    public async Task<Cliente?> ObterPorIdAsync(Guid id)
    {
        return await _context.Clientes.FindAsync(id);
    }

    public async Task AdicionarAsync(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
        
    }
}
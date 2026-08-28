using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Repositories;

public interface IClienteRepository
{
    Task<List<Cliente>> ObterTodosAsync();
    Task<Cliente?>ObterPorIdAsync(Guid id);
    Task AdicionarAsync(Cliente cliente);
}
using WebApplication1.Models;

namespace WebApplication1.Repositories;

public interface IGeneroRepository
{
    Task<List<Genero>> ObterTodosAsync();
    Task<Genero> ObterPorIdAsync(int id);
    Task AdicionarAsync(Genero genero);
    
}
using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IGeneroService
{
    Task<List<Genero>> ListarAsync();
    Task<Genero> ObterPorIdAsync(int id);
    Task<Genero> CriarAsync(Genero genero);

}
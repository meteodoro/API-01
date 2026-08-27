using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class GeneroService : IGeneroService
{
    private readonly IGeneroRepository _repository;
    
    public GeneroService(IGeneroRepository repository)
    {
        _repository = repository;
    }
    
    public Task<List<Genero>> ListarAsync()
    {
        return _repository.ObterTodosAsync();
    }

    public Task<Genero> ObterPorIdAsync(int id)
    {
        return _repository.ObterPorIdAsync(id);
    }

    public async Task<Genero> CriarAsync(Genero genero)
    {
        await _repository.AdicionarAsync(genero);
        return genero;
    }
}
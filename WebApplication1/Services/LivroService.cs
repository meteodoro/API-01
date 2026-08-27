using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class LivroService : ILivroService
{
    private readonly ILivroRepository _repository;

    public LivroService(ILivroRepository repository)
    {
        _repository = repository;
    }
    
    public Task<List<Livro>> ListarAsync()
    {
        return _repository.ObterTodosAsync();
    }

    public Task<Livro?> ObterPorIdAsync(int id)
    {
        return _repository.ObterPorIdAsync(id);
    }

    public async Task<Livro> CriarAsync(Livro livro)
    {
        await _repository.AdicionarAsync(livro);
        return livro;
    }

    public async Task<bool> AtualizarAsync(int id, Livro livro)
    {
        var existente = await _repository.ObterPorIdAsync(id);
        if(existente is null) return false;
        
        existente.Titulo = livro.Titulo;
        existente.Autor = livro.Autor;
        existente.Genero = livro.Genero;
        existente.DataPublicacao = livro.DataPublicacao;
        existente.Preco = livro.Preco;
        await _repository.AtualizarAsync(existente);
        return true;
    }

    public async Task<bool> RemoverAsync(int id)
    {
        var livro = await _repository.ObterPorIdAsync(id);
        if (livro is null) return  false;
        
        await _repository.RemoverAsync(livro);
        return true;
    }
}
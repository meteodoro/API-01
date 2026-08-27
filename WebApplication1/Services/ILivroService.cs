using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Services;

public interface ILivroService
{
    Task<List<Livro>> ListarAsync(string? autor = null);
    Task<Livro?> ObterPorIdAsync(int id);
    Task<Livro> CriarAsync(LivroDto livro);
    Task <bool> AtualizarAsync(int id, Livro livro);
    Task <bool> RemoverAsync(int id);
    
}
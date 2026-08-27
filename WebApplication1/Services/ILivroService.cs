using WebApplication1.Models;

namespace WebApplication1.Services;

public interface ILivroService
{
    Task<List<Livro>> ListarAsync();
    Task<Livro?> ObterPorIdAsync(int id);
    Task<Livro> CriarAsync(Livro livro);
    Task <bool> AtualizarAsync(int id, Livro livro);
    Task <bool> RemoverAsync(int id);
}
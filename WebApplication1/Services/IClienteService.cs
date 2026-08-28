using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IClienteService
{
    Task<List<Cliente>> ListarAsync();
    Task<Cliente> ObterPorIdAsync(Guid id);
    Task<(Cliente? cliente, string? erro)> CriarAsync(Cliente cliente);
}
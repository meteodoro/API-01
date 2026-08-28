using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;

    public ClienteService(IClienteRepository repository)
    {
        _repository = repository;
    }

    public Task<List<Cliente>> ListarAsync()
    {
        return _repository.ObterTodosAsync();
    }

    public Task<Cliente> ObterPorIdAsync(Guid id)
    {
        return _repository.ObterPorIdAsync(id);
    }

    public async Task<(Cliente? cliente, string? erro)> CriarAsync(Cliente cliente)
    {
        cliente.Id = Guid.NewGuid();
        
        await _repository.AdicionarAsync(cliente);
        return (cliente, null);
    }
}
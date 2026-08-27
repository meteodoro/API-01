using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivroController : ControllerBase
{
    private readonly ILivroService _service;
    
    public LivroController(ILivroService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Livro>>> Listar()
    {
        return Ok(await _service.ListarAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Livro>> ObterPorId(int id)
    {
        var livro = await _service.ObterPorIdAsync(id);
        return livro is null ? NotFound() : Ok(livro);
    }

    [HttpPost]
    public async Task<ActionResult<Livro>> Criar(Livro livro)
    {
        var criado = await _service.CriarAsync(livro);
        return CreatedAtAction(nameof(ObterPorId), new {id = criado.ID}, criado);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Atualizar(int id, Livro livro)
    {
        var ok = await _service.AtualizarAsync(id, livro);
        return ok ? NoContent() : NotFound();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Remover(int id)
    {
        var ok = await _service.RemoverAsync(id);
        return ok ? NoContent() : NotFound(); 
    }
}
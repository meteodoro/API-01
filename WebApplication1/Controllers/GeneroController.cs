using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GeneroController : ControllerBase
{
    private readonly IGeneroService _service;
    
    public GeneroController(IGeneroService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Genero>>> ObterTodos()
    {
        return Ok (await _service.ListarAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Genero>> ObterPorId(int id)
    {
        return Ok(await _service.ObterPorIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult<Genero>> Criar(Genero genero)
    {
        var criado = await _service.CriarAsync(genero);
        return CreatedAtAction(nameof(ObterPorId), new {id = criado.Id}, criado);    
    }
}
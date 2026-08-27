using System.Text.Json.Serialization;

namespace WebApplication1.Models;

public class Genero
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    [JsonIgnore] 
    public List<Livro> Livros { get; set; } = new();

    public static implicit operator Genero(Task<Genero?> v)
    {
        throw new NotImplementedException();
    }
}
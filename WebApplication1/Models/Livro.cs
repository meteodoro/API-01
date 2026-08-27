namespace WebApplication1.Models;

public class Livro
{
    public int ID { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string Genero { get; set; }
    public DateTime DataPublicacao { get; set; }
    public decimal Preco { get; set; }
    
}
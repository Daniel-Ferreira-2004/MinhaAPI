using System.Collections.ObjectModel;

namespace MinhaAPI.Models;

public class Categoria
{
    public Categoria()
    {
               Produtos = new Collection<Produto>();
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? ImagemURL { get; set; }

    public ICollection<Produto>? Produtos { get; set; }
}

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MinhaAPI.Models;

public class Categoria
{
    public Categoria()
    {
               Produtos = new Collection<Produto>();
    }
    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemURL { get; set; }
    [JsonIgnore]
    public ICollection<Produto>? Produtos { get; set; }
}

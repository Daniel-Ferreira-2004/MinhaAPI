using System.ComponentModel.DataAnnotations;

namespace MinhaAPI.DTOs
{
    public class produtoDTO
    {
        public int ProdutoId { get; set; }
        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string? Descricao { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemURL { get; set; }
        public int CategoriaId { get; set; }
    }
}

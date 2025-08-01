using MinhaAPI.Models;

namespace MinhaAPI.Repositories
{
    public interface IProdutosRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetProdutosPorCategoria(int id);
    }
}

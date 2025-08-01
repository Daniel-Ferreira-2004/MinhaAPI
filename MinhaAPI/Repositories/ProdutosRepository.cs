using MinhaAPI.Context;
using MinhaAPI.Models;

namespace MinhaAPI.Repositories
{
    public class ProdutosRepository : Repository<Produto>, IProdutosRepository
    {
        public ProdutosRepository(AppDbContext context):base(context)
        {
        }

        public IEnumerable<Produto> GetProdutosPorCategoria(int id)
        {
            return GetAll().Where(c => c.CategoriaId == id).ToList();
        }
    }
}

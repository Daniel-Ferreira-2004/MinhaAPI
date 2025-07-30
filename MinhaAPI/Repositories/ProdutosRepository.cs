using MinhaAPI.Context;
using MinhaAPI.Models;

namespace MinhaAPI.Repositories
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly AppDbContext _context;

        public ProdutosRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Produto> GetProdutos()
        {
            return _context.Produtos;

        }
        public Produto GetProduto(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null)
            {
                throw new InvalidOperationException($"Produto with ID {id} not found.");
            }
            return produto;
        }

        public Produto Create(Produto produto)
        {
            if (produto == null)
            {
                throw new InvalidOperationException("Produto cannot be null.");
            }
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;

        }
        public bool Update(Produto produto)
        {
            if (produto == null)
                throw new InvalidOperationException("Produto cannot be null.");
            
            if (_context.Produtos.Any(p => p.ProdutoId == produto.ProdutoId))
            {
               _context.Produtos.Update(produto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    

        public bool Delete(int id)
        {
            var produto = _context.Produtos.Find(id);

            if (produto == null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

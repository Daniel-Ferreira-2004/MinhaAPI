using Microsoft.EntityFrameworkCore;
using MinhaAPI.Context;
using MinhaAPI.Models;

namespace MinhaAPI.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public Categoria GetCategoria(int id)
        {
            return _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);

        }

        public IEnumerable<Categoria> GetCategorias()
        {
            return _context.Categorias.ToList();
        }

        public Categoria Create(Categoria categoria)
        {
           if (categoria is null)
            {
                throw new ArgumentNullException(nameof(categoria), "Categoria não pode ser nula");
            }

            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }

        public Categoria Update(Categoria categoria)
        {
            if (categoria is null)
            {
                throw new ArgumentNullException(nameof(categoria), "Categoria não pode ser nula");
            }
            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();
            return categoria;
        }
        public Categoria Delete(int id)
        {
            var categoria = _context.Categorias.Find(id);
            if (categoria is null)
            {
                throw new KeyNotFoundException($"Categoria com ID {id} não encontrada");
            }
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
            return categoria;

        }
    }
}

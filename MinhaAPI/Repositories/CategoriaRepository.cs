using Microsoft.EntityFrameworkCore;
using MinhaAPI.Context;
using MinhaAPI.Models;

namespace MinhaAPI.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context): base(context)
        {
 
        }
    }
}

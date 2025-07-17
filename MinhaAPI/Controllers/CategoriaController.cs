using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaAPI.Context;
using MinhaAPI.Filters;
using MinhaAPI.Models;

namespace MinhaAPI.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;
        public CategoriaController(AppDbContext context, ILogger<CategoriaController> logger)
        {
            _context = context;
            _logger = logger;
        }
        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            _logger.LogInformation("### Executando -> GetCategoriasProdutos ###");
            return _context.Categorias.Include(p=> p.Produtos).ToList();
        }

        [HttpGet]
        [ServiceFilter(typeof(ApiLoggingFilter))]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            var Categoria = _context.Categorias.ToList();
            if (Categoria is null)
            {
                return NotFound("Produtos não encontrados");
            }
            return Ok(Categoria);
        }

        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> Get(int id)
        {
            throw new Exception("Exceção ao retornar a categoria pelo ID");

            var Categoria = _context.Categorias.FirstOrDefault(p => p.CategoriaId == id);
            if (Categoria is null)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok(Categoria);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Categoria categoria)
        {
            if (categoria is null)
            {
                return BadRequest("Não encontrado");
            }

            _context.Categorias.Add(categoria);
            _context.SaveChanges();

            return CreatedAtRoute("ObterProduto", new { id = categoria.CategoriaId }, categoria);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                return BadRequest("ID do produto não corresponde ao ID na URL");
            }

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(produto => produto.CategoriaId == id);
            if (categoria is null)
            {
                return NotFound("Produto não localizado...");
            }
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return Ok(categoria);
        }

    }

    public class Enumerable<T>
    {
    }
}

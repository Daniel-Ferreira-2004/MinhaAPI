using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaAPI.Context;
using MinhaAPI.Filters;
using MinhaAPI.Models;
using MinhaAPI.Repositories;

namespace MinhaAPI.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IRepository<Categoria> _repository;
        private readonly ILogger _logger;
        public CategoriaController(IRepository<Categoria> repository, ILogger<CategoriaController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            _logger.LogInformation("Obtendo categorias com produtos associados");
            var categorias = _repository.GetAll();
            if (categorias is null || !categorias.Any())
            {
                return NotFound("Nenhuma categoria encontrada");
            }
            return Ok(categorias);

        }

        [HttpGet]
        [ServiceFilter(typeof(ApiLoggingFilter))]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            var categoria = _repository.GetAll();
            return Ok(categoria);

        }

        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _repository.Get(c=> c.CategoriaId == id);
            if (categoria is null)
            {
                return NotFound("Categoria não encontrada");
            }
            return Ok(categoria);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Categoria categoria)
        {
            if (categoria is null)
            {
                return BadRequest("Não encontrado");
            }

            var CategoriaCriada = _repository.add(categoria);
            return CreatedAtRoute("ObterCategoria", new { id = CategoriaCriada.CategoriaId }, CategoriaCriada);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                return BadRequest("ID do produto não corresponde ao ID na URL");
            }

            var updatedCategoria = _repository.update(categoria);
            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var categoria = _repository.Get(c=> c.CategoriaId == id);
            if (categoria is null)
            {
                return NotFound("Categoria não encontrada");
            }
            var categoriaExcluida = _repository.delete(categoria);
            return Ok(categoriaExcluida);
        }

    }
}

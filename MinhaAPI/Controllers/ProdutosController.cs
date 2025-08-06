using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaAPI.Context;
using MinhaAPI.Models;
using MinhaAPI.Repositories;

namespace MinhaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosRepository _produtoRepository;
        private readonly IRepository<Produto> _repository;

        public ProdutosController(IRepository<Produto> repository,
            IProdutosRepository produtoRepository)
        {
            _repository = repository;
            _produtoRepository = produtoRepository;
        }

        [HttpGet("produtos/{id}")]
        public ActionResult<IEnumerable<Produto>> GetProdutosPorCategoria(int id)
        {
            var produtos = _produtoRepository.GetProdutosPorCategoria(id);
            if (produtos is null || !produtos.Any())
            {
                return NotFound("Nenhum produto encontrado para a categoria especificada");
            }
            return Ok(produtos);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _repository.GetAll();
            if (produtos is null)
            {
                return NotFound("Produtos não encontrados");
            }
            return Ok(produtos);
        }

        [HttpGet ("{id:int}", Name ="ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _repository.Get(p=> p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok(produto);
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
            {
                return BadRequest();
            }

            var novoProduto = _repository.add(produto);
            return new CreatedAtRouteResult("ObterProduto",
            new { id = novoProduto.ProdutoId }, novoProduto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest("ID do produto não corresponde ao ID na URL");
            }
            var produtoAtualizado = _repository.update(produto);

            return Ok(produtoAtualizado);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var produto = _repository.Get(p => p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado");
            }
            _repository.delete(produto);
            return Ok("Produto excluído com sucesso");
        }
    }
}

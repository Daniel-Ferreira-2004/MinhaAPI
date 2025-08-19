using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaAPI.Context;
using MinhaAPI.DTOs;
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
        private readonly IMapper _mapper;

        public ProdutosController(IRepository<Produto> repository,
            IProdutosRepository produtoRepository,
            IMapper mapper)
        {
            _repository = repository;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        [HttpGet("produtos/{id}")]
        public ActionResult<IEnumerable<produtoDTO>> GetProdutosPorCategoria(int id)
        {
            var produtos = _produtoRepository.GetProdutosPorCategoria(id);
            if (produtos is null || !produtos.Any())
            {
                return NotFound("Nenhum produto encontrado para a categoria especificada");
            }
            var produtosDTO = _mapper.Map<IEnumerable<produtoDTO>>(produtos);
            return Ok(produtosDTO);
        }

        [HttpGet]
        public ActionResult<IEnumerable<produtoDTO>> Get()
        {
            var produtos = _repository.GetAll();
            if (produtos is null)
            {
                return NotFound("Produtos não encontrados");
            }
            var produtosDTO = _mapper.Map<IEnumerable<produtoDTO>>(produtos);

            return Ok(produtosDTO);
        }

        [HttpGet ("{id:int}", Name ="ObterProduto")]
        public ActionResult<produtoDTO> Get(int id)
        {
            var produto = _repository.Get(p=> p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado");
            }
            var produtoDTO = _mapper.Map<produtoDTO>(produto);
            return Ok(produtoDTO);
        }

        [HttpPost]
        public ActionResult<produtoDTO> Post(produtoDTO produtoDTO)
        {
            if (produtoDTO is null)
            {
                return BadRequest();
            }
            var produto = _mapper.Map<Produto>(produtoDTO);

            var novoProduto = _repository.add(produto);

            var produtoDTOResult = _mapper.Map<produtoDTO>(novoProduto);

            return new CreatedAtRouteResult("ObterProduto",
            new { id = produtoDTOResult.ProdutoId }, produtoDTOResult);
        }

        [HttpPut("{id:int}")]
        public ActionResult<produtoDTO> Put(int id, produtoDTO produtoDTO)
        {
            if (id != produtoDTO.ProdutoId)
            {
                return BadRequest("ID do produto não corresponde ao ID na URL");
            }
            var produto = _mapper.Map<Produto>(produtoDTO);

            var produtoAtualizado = _repository.update(produto);

            var produtoAtualizadoDTO = _mapper.Map<produtoDTO>(produtoAtualizado);

            return Ok(produtoAtualizadoDTO);
        }

        [HttpDelete("{id:int}")]
        public ActionResult<produtoDTO> Delete(int id)
        {
            var produto = _repository.Get(p => p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado");
            }
            var produtoDeletado = _repository.delete(produto);

            var produtoDeletadoDTO = _mapper.Map<produtoDTO>(produtoDeletado);

            return Ok(produtoDeletadoDTO);
        }
    }
}

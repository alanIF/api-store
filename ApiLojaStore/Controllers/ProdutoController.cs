using ApiLojaStore.Context;
using ApiLojaStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiLojaStore.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly BDContext _context;
        public ProdutoController(BDContext context)
        {
            _context = context;

        }
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos.ToListAsync();
            if (produtos is null)
            {
                return NotFound();
            }

            return Ok(produtos);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([Bind("Id,Nome,EstoqueMinimo")] Produto produto)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();


            return Ok(produto);
        }
        [HttpPatch("Update")]
        public async Task<IActionResult> Update(int id, [Bind("Id,Nome,EstoqueMinimo")] Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }


            try
            {
                _context.Update(produto);
                await _context.SaveChangesAsync();
                return Ok(produto);

            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return NotFound();

        }
        [HttpDelete("Delete")]

        public async Task<IActionResult> Delete(int? id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return Ok("Produto excluído com sucesso");

        }
    }
}


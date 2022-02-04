using ApiLojaStore.Context;
using ApiLojaStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiLojaStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class VendaController : Controller
    {
        private readonly BDContext _context;
        public VendaController(BDContext context)
        {
            _context = context;

        }
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var vendas = await _context.Vendas.ToListAsync();
            if (vendas is null)
            {
                return NotFound();
            }

            return Ok(vendas);
        }
        [HttpGet("view")]
        public async Task<IActionResult> View(int id)
        {
            var venda = await _context.Vendas.FindAsync(id);
            if (venda is null)
            {
                return NotFound();
            }

            return Ok(venda);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([Bind("Id,data_venda, qtd, observacao, idComprador, idProduto")] Venda venda)
        {
            _context.Add(venda);
            await _context.SaveChangesAsync();


            return Ok(venda);
        }
        [HttpPatch("Update")]
        public async Task<IActionResult> Update(int id, [Bind("Id,data_venda, qtd, observacao, idComprador, idProduto")] Venda venda)
        {
            if (id != venda.Id)
            {
                return NotFound();
            }


            try
            {
                _context.Update(venda);
                await _context.SaveChangesAsync();
                return Ok(venda);

            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return NotFound();

        }
        [HttpDelete("Delete")]

        public async Task<IActionResult> Delete(int? id)
        {
            var venda = await _context.Vendas.FindAsync(id);
            
            _context.Vendas.Remove(venda);
            await _context.SaveChangesAsync();
            return Ok("Venda excluída com sucesso");

        }

    }
}

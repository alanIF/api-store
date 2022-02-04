using ApiLojaStore.Context;
using ApiLojaStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiLojaStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EntradaController : Controller
    {
        private readonly BDContext _context;
        public EntradaController(BDContext context)
        {
            _context = context;

        }
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var entradas = await _context.Entradas.ToListAsync();
            if (entradas is null)
            {
                return NotFound();
            }

            return Ok(entradas);
        }
        [HttpGet("view")]
        public async Task<IActionResult> View(int id)
        {
            var entrada = await _context.Entradas.FindAsync(id);
            if (entrada is null)
            {
                return NotFound();
            }

            return Ok(entrada);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([Bind("Id,titulo,data_entrada,qtd, data_validade,data_fabricacao, observacao, idUser, idProduto")] Entrada entrada)
        {
            _context.Add(entrada);
            await _context.SaveChangesAsync();


            return Ok(entrada);
        }
        [HttpPatch("Update")]
        public async Task<IActionResult> Update(int id, [Bind("Id,titulo,data_entrada, qtd, data_validade,data_fabricacao, observacao, idUser, idProduto")] Entrada entrada)
        {
            if (id != entrada.Id)
            {
                return NotFound();
            }


            try
            {
                _context.Update(entrada);
                await _context.SaveChangesAsync();
                return Ok(entrada);

            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return NotFound();

        }
        [HttpDelete("Delete")]

        public async Task<IActionResult> Delete(int? id)
        {
            var entrada = await _context.Entradas.FindAsync(id);
            _context.Entradas.Remove(entrada);
            await _context.SaveChangesAsync();
            return Ok("Entrada excluída com sucesso");

        }
    
}
}

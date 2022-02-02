using Microsoft.AspNetCore.Mvc;

namespace ApiLojaStore.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

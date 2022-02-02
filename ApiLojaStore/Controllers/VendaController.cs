using Microsoft.AspNetCore.Mvc;

namespace ApiLojaStore.Controllers
{
    public class VendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

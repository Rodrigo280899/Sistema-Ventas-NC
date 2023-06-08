using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.Controllers
{
    public class ReporteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

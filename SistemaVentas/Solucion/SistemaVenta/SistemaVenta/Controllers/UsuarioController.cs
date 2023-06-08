using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

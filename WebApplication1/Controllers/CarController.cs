using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

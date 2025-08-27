using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Artist()
        {
            return View();
        }
        public IActionResult More()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BackEndNETLINUX.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return Content("Bienvenido a TempoTrack!");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ERD_Design.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

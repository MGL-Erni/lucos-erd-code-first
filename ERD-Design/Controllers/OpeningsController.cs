using Microsoft.AspNetCore.Mvc;

namespace ERD_Design.Controllers
{
    public class OpeningsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

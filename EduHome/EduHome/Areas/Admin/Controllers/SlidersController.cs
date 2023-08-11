using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

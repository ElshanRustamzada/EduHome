using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactVM contactVM)
        {
            string message = 
                $"<p>Subject:{contactVM.Subject}</p></br>" +
                $"<p>Name:{contactVM.Name}</p></br>" +
                $"<p>Message:{contactVM.Message}</p></br>" +
                $"<p>Email:{contactVM.Email}</p></br>";
            await Helpers.Helper.SendMailAsync("Muraciet", message, "elshanrustamzada@yandex.com");
            ViewBag.Message = "Mesaj gonderildi.";
            return View();
        }
    }
}

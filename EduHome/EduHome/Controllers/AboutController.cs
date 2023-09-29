using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}


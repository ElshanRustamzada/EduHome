using EduHome.DAL;
using EduHome.Helpers;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using Extensions = EduHome.Helpers.Extensions;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly AppDbContext _db;
        public SlidersController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _db.Sliders.ToListAsync();
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (slider.Photo == null)
            {
                ModelState.AddModelError("Photo", "Image can not be null");
                return View();
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select image type");
                return View();
            }
            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

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
        #region Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (slider.Photo==null)
            {
                ModelState.AddModelError("Photo", "please select photo");
                return View();
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "please select image type");
                return View();
            }
            if (slider.Photo.IsOrder1Mb())
            {
                ModelState.AddModelError("Photo", "max 1mb");
                return View();
            }
            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        } 
        #endregion


        #region Activity
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider dbSlider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbSlider == null)
            {
                return BadRequest();
            }
            if (!dbSlider.IsDeactive)
            {
                dbSlider.IsDeactive = true;
            }
            else
            {
                dbSlider.IsDeactive = false;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

    }

}

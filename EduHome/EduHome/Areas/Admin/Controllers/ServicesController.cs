using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _db;
        public ServicesController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Service> services = await _db.Services.ToListAsync();
            return View(services);
        }

        #region Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            #region Is Exist
            bool isExist = await _db.Services.AnyAsync(x => x.Name == service.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This service is already exist");
                return View();
            }
            #endregion

            await _db.Services.AddAsync(service);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
            {
                return BadRequest();
            }
            return View(dbservice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Service service)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
            {
                return BadRequest();
            }
            #region Is Exist
            bool isExist = await _db.Services.AnyAsync(x => x.Name == service.Name && x.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This service is already exist");
                return View();
            }
            #endregion

            dbservice.Name = service.Name;
            dbservice.Description = service.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
            {
                return BadRequest();
            }
            return View(dbservice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
            {
                return BadRequest();
            }
            dbservice.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (dbservice == null)
            {
                return BadRequest();
            }
            return View(dbservice);
        } 
        #endregion

    }
}

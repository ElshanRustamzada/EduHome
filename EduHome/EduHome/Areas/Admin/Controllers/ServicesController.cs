﻿using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
        public IActionResult Update(int? id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Service service)
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
    }
}

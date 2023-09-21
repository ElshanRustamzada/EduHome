using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class BlogsController : Controller
    {
        private readonly AppDbContext _db;
        public BlogsController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.CurrentPage = page;
            int take = 6;
            ViewBag.PageCount = Math.Ceiling((decimal)(await _db.Blogs.CountAsync()) / take);
            List<Blog> blogs = await _db.Blogs.OrderByDescending(x => x.Id).Skip((page - 1) * take).Take(take).ToListAsync();
            return View(blogs);
        }

    }
}


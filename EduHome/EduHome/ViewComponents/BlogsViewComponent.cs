using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class BlogsViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        public BlogsViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int page=1)
        {
            ViewBag.CurrentPage = page;
            int take = 6;
            ViewBag.PageCount = Math.Ceiling((decimal)(await _db.Blogs.CountAsync()) / take);
            List<Blog> blogs = await _db.Blogs.OrderByDescending(x => x.Id).Skip((page - 1) * take).Take(take).ToListAsync();
            return View(blogs);
        }
    }
}

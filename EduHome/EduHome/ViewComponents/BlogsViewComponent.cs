using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Blog> blogs = await _db.Blogs.Take(take).ToListAsync();
            return View(blogs);
        }
    }
}


using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _db;
        public CoursesController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.CoursesCount = await _db.Courses.CountAsync();

            List<Course> courses = await _db.Courses.OrderByDescending(x => x.Id).Take(6).ToListAsync();
            return View(courses);
        }
        public async Task<IActionResult> LoadMore(int skip)
        {
            int coursesCount = await _db.Courses.CountAsync();
            if(coursesCount <= skip)
            {
                return Content("Get Out!");
            }

            List<Course> courses = await _db.Courses.OrderByDescending(x => x.Id).Skip(skip).Take(6).ToListAsync();
            return PartialView("_CoursesLoadMorePartial", courses);
        }
    }
}

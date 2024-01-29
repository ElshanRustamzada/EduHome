using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class TeachersController : Controller
    {
        private readonly AppDbContext _db;
        public TeachersController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
           List<Teacher> teachers = await _db.Teachers.Include(x=>x.TeacherDetail).Include(x=>x.TeacherCategory).ToListAsync();
            return View(teachers);
        }
    }
}

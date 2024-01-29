using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class EventsController : Controller
    {
        private readonly AppDbContext _db;
        public EventsController(AppDbContext db)
        {
            _db = db;   
        }
        public async Task<IActionResult> Index()
        {
            List<Event> events = await _db.Events.Include(x=>x.Location).ToListAsync();
            return View(events);
        }
    }
}

using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class FeedbackViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        public FeedbackViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Feedback feedback = await _db.Feedback.FirstOrDefaultAsync();   
            return View(feedback);
        }
    }
}

using EduHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EduHome.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Header> Header { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCategory> TeacherCategories { get; set; }
        public DbSet<TeacherDetail> TeacherDetails { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }


    }
}

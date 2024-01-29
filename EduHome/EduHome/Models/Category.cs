using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<CourseCategory> CourseCategories { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<EventCategory> EventCategories { get; set; }
        public ICollection<TeacherCategory> TeacherCategory { get; set; }
        public ICollection<BlogCategory> BlogCategories { get; set; }
    }
}

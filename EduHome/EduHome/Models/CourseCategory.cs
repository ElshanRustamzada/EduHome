namespace EduHome.Models
{
    public class CourseCategory
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public int CourseID { get; set; }
        public Category Categories { get; set; }
        public int CategoriesID { get; set; }
    }
}

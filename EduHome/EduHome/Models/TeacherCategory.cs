namespace EduHome.Models
{
    public class TeacherCategory
    {
        public int ID { get; set; }
        public int CategoriesID { get; set; }
        public Category Categories { get; set; }
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
    }
}

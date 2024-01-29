namespace EduHome.Models
{
    public class BlogCategory
    {
        public int Id { get; set; }
        public Blog Blog { get; set; }
        public int BlogID { get; set; }
        public Category Categories { get; set; }
        public int CategoriesID { get; set; }
    }
}

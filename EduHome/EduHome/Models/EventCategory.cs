namespace EduHome.Models
{
    public class EventCategory
    {
        public int ID { get; set; }
        public Event Event { get; set; }
        public int EventID { get; set; }
        public Category Categories { get; set; }
        public int CategoryID { get; set; }
    }
}

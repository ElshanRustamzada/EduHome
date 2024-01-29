using System;

namespace EduHome.Models
{
    public class Event : BaseEntity
    {
        public override int Id { get; set; }

        public string Title { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}

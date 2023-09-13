using System;

namespace EduHome.Models
{
	public class Event
	{
		public int Id { get; set; }
		public string EventImageName { get; set; }
		public string Title { get; set; }
		public DateTime EventTime { get; set; }
		public string EventCity { get; set; }
		public bool IsDeactive { get; set; }
	}
}

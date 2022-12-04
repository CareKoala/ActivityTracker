using Domain.Classes;

namespace Domain
{
	public class Activity
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public Category Category { get; set; }
		public IEnumerable<Interval> Intervals { get; set; }

		public Activity(Category category)
		{
			Category = category;
			Intervals = new List<Interval>();
		}
	}
}
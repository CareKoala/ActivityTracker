namespace Domain.Classes
{
	public class Activity
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public Category Category { get; set; }
		public IEnumerable<Interval> Intervals { get; set; }

		public Activity(string name, Category category)
		{
			Category = category;
			Intervals = new List<Interval>();
			Name = name;
		}
	}
}
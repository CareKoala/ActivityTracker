namespace ActivityTracker.Models.Interval
{
	public class CreateIntervalInput
	{
		public string Name { get; set; } = string.Empty;
		public int CategoryId { get; set; } = 0;
	}
}

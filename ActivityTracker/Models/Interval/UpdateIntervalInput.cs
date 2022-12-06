namespace ActivityTracker.Models.Interval
{
	public class UpdateIntervalInput
	{
		public int Id { get; set; }
		public int ActivityId { get; set; }
		public string Description { get; set; } = string.Empty;
	}
}

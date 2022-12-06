namespace Domain.Classes
{
	public class Interval
	{
		/// <summary>
		/// Id of the Interval. Used to find it again after creation.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The Id of the activity which the interval should be added to.
		/// </summary>
		public int ActivityId { get; set; }

		/// <summary>
		/// Defines when the Interval starts. This is defined in UTC.
		/// </summary>
		public DateTime StartInstant { get; set; } = DateTime.UtcNow;

		/// <summary>
		/// Defines when the Interval ends. This is defined in UTC.
		/// </summary>
		public DateTime? EndInstant { get; set; }

		/// <summary>
		/// Describes what was done during the period of the activity.
		/// </summary>
		public string? Description { get; set; }

		public Interval(int activityId)
		{
			ActivityId = activityId;
		}
	}
}

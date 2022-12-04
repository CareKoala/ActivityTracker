namespace Domain.Classes
{
	public class Interval
	{
		/// <summary>
		/// Defines when the Interval starts. This is defined in UTC.
		/// </summary>
		public DateTime StartInstant { get; set; }

		/// <summary>
		/// Defines when the Interval ends. This is defined in UTC.
		/// </summary>
		public DateTime EndInstant { get; set; }

		/// <summary>
		/// Describes what was done during the period of the activity.
		/// </summary>
		public string? Description { get; set; }

	}
}

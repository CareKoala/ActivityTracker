using ActivityTracker.Models.Activity;

namespace ActivityTracker.Models.Interval
{
	public class CreateIntervalOutput : BaseOutput
	{
		/// <summary>
		/// The Id of the activity just created.
		/// </summary>
		public int Id { get; set; }
	}
}

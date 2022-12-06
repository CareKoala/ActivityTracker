using System.ComponentModel.DataAnnotations;

namespace ActivityTracker.Models.Interval
{
	public class CreateIntervalInput
	{
		[Required]
		public int ActivityId { get; set; }
	}
}
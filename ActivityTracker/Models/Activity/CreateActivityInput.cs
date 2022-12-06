using System.ComponentModel.DataAnnotations;

namespace ActivityTracker.Models.Activity
{
	public class CreateActivityInput
	{
		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		public int CategoryId { get; set; }

	}
}

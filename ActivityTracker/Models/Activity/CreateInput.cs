using ActivityTracker.Models.Base;

namespace ActivityTracker.Models.Activity
{
	public class CreateInput : IBaseInput
	{
		public string Name { get; set; } = string.Empty;
		public int CategoryId { get; set; } = 0;
	}
}

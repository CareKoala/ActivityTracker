namespace ActivityTracker.Models.Activity
{
	public abstract class BaseOutput
	{
		/// <summary>
		/// Status that defines if the action invokes went as planned or not.
		/// </summary>
		public ResponseStatus Status { get; set; }

		/// <summary>
		/// Error message if some error occours during the action invoked.
		/// </summary>
		public string? ErrorMessage { get; set; }
	}

	public enum ResponseStatus
	{
		Success,
		PartialSuccess,
		Error
	}
}
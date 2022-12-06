namespace ActivityTracker.Models.Activity
{
	//The desire for this call was to have a common place to has status/exception handling.
	public abstract class BaseOutput
	{
		public string StatusMessage { get; set; } = string.Empty;

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
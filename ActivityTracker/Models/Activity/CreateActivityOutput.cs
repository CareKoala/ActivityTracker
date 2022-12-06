namespace ActivityTracker.Models.Activity
{
	public class CreateActivityOutput: BaseOutput
	{
		/// <summary>
		/// The Id of the activity just created.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The name of the category the activity is used for.
		/// </summary>
		public string CategoryName { get; set; } = string.Empty;

		public CreateActivityOutput(int id, string categoryName, ResponseStatus status, string? errorMessage)
		{
			Id = id;
			CategoryName = categoryName;
			ErrorMessage = errorMessage;
			StatusMessage = status.ToString();
		}
	}
}

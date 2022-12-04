namespace Domain.Repositories
{
	public class ActivityCreateModel
	{
		public string? Name { get; set; }
		public int CategoryId { get; set; }

		public ActivityCreateModel(string name, int categoryId)
		{
			Name = name;
			CategoryId = categoryId;
		}
	}
}
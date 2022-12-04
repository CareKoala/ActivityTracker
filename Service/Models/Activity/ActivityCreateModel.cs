using Domain.Classes;

namespace Domain.Repositories
{
	public class ActivityCreateModel
	{
		public string? Name { get; set; }
		public int CategoryId { get; set; }
		public string CategoryDescription { get; set; } = string.Empty;


		public ActivityCreateModel(string name, Category category)
		{
			Name = name;
			CategoryId = category.Id;
			CategoryDescription = category.Description;
		}
	}
}
namespace Service.Models.Activity
{
	public class ActivityCreateModel
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int CategoryId { get; set; }
		public string CategoryDescription { get; set; } = string.Empty;


		public ActivityCreateModel(int id, string name, CategoryModel category)
		{
			Id = id;
			Name = name;
			CategoryId = category.Id;
			CategoryDescription = category.Description;
		}
	}
}
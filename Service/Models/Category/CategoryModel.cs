using Domain.Classes;

namespace Service.Models
{
	public class CategoryModel
	{
		public int Id { get; set; }
		public string Description { get; set; } = string.Empty;

		public CategoryModel(int id, string description)
		{
			Id = id;
			Description = description;
		}

		public CategoryModel(Category category)
		{
			Id = category.Id;
			Description = category.Description;
		}
	}
}

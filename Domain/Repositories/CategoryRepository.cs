using Domain.Classes;

namespace Service
{
	public class CategoryRepository
	{
		ICollection<Category> _categories;

		public CategoryRepository()
		{
			_categories = new List<Category>();
			PopuleteCategories();
		}

		public Category Create(int id, string description)
		{
			Category category = new(id, description);

			return category;
		}

		public Category Get(int categoryId)
		{
			return _categories.Where(cat => cat.Id == categoryId).FirstOrDefault() ?? throw new Exception($"No category found with Id: {categoryId}");
		}

		private void PopuleteCategories()
		{
			_categories.Add(new Category(1, "Arbejde"));
			_categories.Add(new Category(2, "Fritid"));
			_categories.Add(new Category(3, "Familie"));
		}
	}
}
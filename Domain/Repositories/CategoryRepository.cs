using Domain.Classes;
using Domain.Repositories;

namespace Service
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly ICollection<Category> _categories;

		public CategoryRepository()
		{
			_categories = new List<Category>();
			PopuleteCategories();
		}

		public Category Create(string description)
		{
			Category category = new(description);

			return category;
		}

		public Category Read(int categoryId)
		{
			return _categories.Where(cat => cat.Id == categoryId).FirstOrDefault() ?? throw new Exception($"No category found with Id: {categoryId}");
		}

		private void PopuleteCategories()
		{
			//Id not part of the constructor in real application, so manually added here as a hack to compensate for lack of persitence.
			_categories.Add(new Category("Sparetime") { Id = 1 });
			_categories.Add(new Category("Chores") { Id = 2 });
		}
	}
}
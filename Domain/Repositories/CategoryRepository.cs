using Domain.Classes;

namespace Service
{
	public class CategoryRepository
	{
		public CategoryRepository()
		{
		}

		public Category Create(int id, string description)
		{
			Category category = new()
			{
				Id = id,
				Description = description
			};

			return category;
		}

		public Category Get(int categoryId)
		{
			return new() { Description = "Test", Id = categoryId };
		}
	}
}
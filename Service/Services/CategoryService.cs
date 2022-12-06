using Domain.Classes;
using Domain.Repositories;
using Service.Interfaces;

namespace Service.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;

		public CategoryService(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public void Create(string name, int categoryId)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Category Read(int categoryId)
		{
			Category category = _categoryRepository.Read(categoryId);

			return category;
		}
	}
}

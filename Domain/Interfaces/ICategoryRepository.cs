using Domain.Classes;

namespace Domain.Repositories
{
	public interface ICategoryRepository
	{
		public Category Create(string description);
		public Category Read(int categoryId);
	}
}

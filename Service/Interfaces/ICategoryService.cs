using Domain.Classes;

namespace Service.Interfaces
{
	public interface ICategoryService
	{
		public void Create(string name, int categoryId);
		public Category Read(int id);
		public void Delete(int id);
	}
}

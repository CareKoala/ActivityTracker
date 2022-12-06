using Service.Models.Activity;

namespace Service.Interfaces
{
	public interface IActivityService
	{
		public ActivityCreateModel Create(string name, int categoryId);
		public void Read(int id);
		public void Delete(int id);
	}
}

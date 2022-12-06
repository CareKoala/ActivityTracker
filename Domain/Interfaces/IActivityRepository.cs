using Domain.Classes;

namespace Domain.Repositories
{
	public interface IActivityRepository
	{
		public Activity Create(string name, Category category);

		public Activity Read(int activityId);
	}
}

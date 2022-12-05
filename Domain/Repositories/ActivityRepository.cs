using Domain.Classes;

namespace Domain.Repositories
{
	public class ActivityRepository : IActivityRepository
	{
		public Activity Create(string name, Category category)
		{
			//Create entity in db from Model and return id;
			return new Activity(name, category);
		}
	}
}

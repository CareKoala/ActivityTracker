using Domain.Classes;

namespace Domain.Repositories
{
	public class ActivityRepository : IActivityRepository
	{
		private readonly ICollection<Activity> _activities;

		public ActivityRepository()
		{
			_activities = new List<Activity>();
		}

		public Activity Create(string name, Category category)
		{
			Activity activity = new Activity(name, category);
			
			//Simple hack to simulate DB id.
			activity.Id = _activities.Count + 1;
			_activities.Add(activity);

			return activity;
		}

		public Activity Read(int activityId)
		{
			return _activities.FirstOrDefault(activity => activity.Id == activityId);
				
		}
	}
}

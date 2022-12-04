using Domain.Classes;
using Domain.Repositories;
using Service.Interfaces;

namespace Service
{
	public class ActivityService : IService
	{
		private readonly ActivityRepository _activityRepository;
		private readonly CategoryRepository _categoryRepository;


		public ActivityService()
		{
			_activityRepository = new ActivityRepository();
			_categoryRepository = new CategoryRepository();
		}

		public ActivityCreateModel Create(string name, int categoryId)
		{
			Category category = _categoryRepository.Get(categoryId);
			Activity activity = _activityRepository.Create(name, category);

			ActivityCreateModel model = new(activity.Name, category);

			return model;
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}


		public void Read(int id)
		{
			throw new NotImplementedException();
		}
	}
}
using Domain.Classes;
using Domain.Repositories;
using Service.Interfaces;

namespace Service
{
	public class ActivityService : IActivityService
	{
		private readonly IActivityRepository _activityRepository;
		private readonly CategoryRepository _categoryRepository;

		public ActivityService(IActivityRepository activityRepository)
		{
			_activityRepository = activityRepository;
			_categoryRepository = new CategoryRepository();
		}

		public void Create(string name, int categoryId)
		{
			//TODO: Get from categoryService instead
			Category category = _categoryRepository.Get(categoryId);
			Activity activity = _activityRepository.Create(name, category);

			ActivityCreateModel model = new(activity.Name, category);
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
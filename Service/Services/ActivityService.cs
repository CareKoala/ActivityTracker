using Domain.Classes;
using Domain.Repositories;
using Service.Interfaces;
using Service.Services;

namespace Service
{
	public class ActivityService : IActivityService
	{
		private readonly IActivityRepository _activityRepository;
		private readonly ICategoryService _categoryService;

		public ActivityService(IActivityRepository activityRepository, ICategoryService categoryService)
		{
			_activityRepository = activityRepository;
			_categoryService = categoryService;
		}

		public void Create(string name, int categoryId)
		{
			Category category = _categoryService.Read(categoryId);
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
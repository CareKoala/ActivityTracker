using Domain.Repositories;
using Service.Interfaces;

namespace Service
{
	public class ActivityService : IService
	{
		private readonly ActivityRepository _repository;

		public ActivityService()
		{
			_repository = new ActivityRepository();
		}

		public void Create(string name, int categoryId)
		{
			ActivityCreateModel model = new(name, categoryId);
			_repository.Create();
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
using Domain.Classes;
using Domain.Repositories;
using Service.Interfaces;
using Service.Services;

namespace Service
{
	public class IntervalService : IIntervalService
	{
		private readonly IIntervalRepository _intervalRepository;

		public IntervalService(IIntervalRepository intervalRepository)
		{
			_intervalRepository = intervalRepository;
		}

		public void Create()
		{
			
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
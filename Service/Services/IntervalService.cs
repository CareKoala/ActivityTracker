using Domain.Classes;
using Domain.Repositories;
using Service.Interfaces;
using Service.Models;

namespace Service
{
	public class IntervalService : IIntervalService
	{
		private readonly IIntervalRepository _intervalRepository;

		public IntervalService(IIntervalRepository intervalRepository)
		{
			_intervalRepository = intervalRepository;
		}

		public IntervalModel Create(int intervalId)
		{
			Interval interval = _intervalRepository.Create(intervalId);

			IntervalModel intervalModel = new(interval);

			return intervalModel;
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}


		public void Read(int id)
		{
			throw new NotImplementedException();
		}

		public bool IsIntervalActiveOnActivity(int activityId)
		{
			IEnumerable<Interval> intervals = _intervalRepository.List(activityId);
			
			return intervals.Any(interval => interval.EndInstant == null);
		}

		public void EndInterval(int id, int activityId, string description)
		{
			Interval interval = _intervalRepository.Read(id);

			if (interval == null)
			{
				throw new Exception($"No interval found for Id: {id}");
			}

			if (interval.ActivityId != activityId)
			{
				throw new Exception($"The interval with Id: {id} is not associated with the Activity with Id: {activityId}");
			}

			interval.Description = description;
			interval.EndInstant = DateTime.UtcNow;
		}
	}
}
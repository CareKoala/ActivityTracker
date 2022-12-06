using Domain.Classes;

namespace Domain.Repositories
{
	public class IntervalRepository : IIntervalRepository
	{
		private readonly ICollection<Interval> _intervals;

		public IntervalRepository()
		{
			_intervals = new List<Interval>();
		}

		public Interval Create(int activityId)
		{
			Interval interval = new Interval(activityId);
			interval.Id = _intervals.Count + 1;
			
			_intervals.Add(interval);

			return interval;
		}

		public Interval Update(int intervalId, DateTime endOfIntervalInstant, string description)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Interval> List(int activityId)
		{
			return _intervals.Where(interval => interval.ActivityId == activityId).ToList();
		}

		public Interval Read(int id)
		{
			return _intervals.Where((interval) => interval.Id == id).FirstOrDefault();
		}
	}
}

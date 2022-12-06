using Domain.Classes;

namespace Domain.Repositories
{
	public interface IIntervalRepository
	{
		public Interval Create(int activityId);
		public Interval Update(int intervalId, DateTime endOfIntervalInstant, string description);
		public IEnumerable<Interval> List(int activityId);
		Interval Read(int id);
	}
}

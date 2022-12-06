using Domain.Classes;

namespace Domain.Repositories
{
	public interface IIntervalRepository
	{
		public Interval Create();
		public Interval Update(int intervalId, DateTime endOfIntervalInstant, string description);
	}
}

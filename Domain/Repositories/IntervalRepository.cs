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

		public Interval Create()
		{
			return new Interval();
		}
	}
}

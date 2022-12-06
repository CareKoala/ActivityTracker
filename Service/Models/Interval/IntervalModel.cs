using Domain.Classes;

namespace Service.Models
{
	public class IntervalModel
	{
		public int Id { get; set; }
		public DateTime IntervalStartInstant { get; set; }


		public IntervalModel(Interval interval)
		{
			Id = interval.Id;
			IntervalStartInstant = interval.StartInstant;
		}
	}
}
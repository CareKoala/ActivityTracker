using Service.Models;

namespace Service.Interfaces
{
	public interface IIntervalService
	{
		public IntervalModel Create(int activityId);
		public void Read(int id);
		public void Delete(int id);
		bool IsIntervalActiveOnActivity(int activityId);
		void EndInterval(int id, int activityId, string description);
	}
}

namespace Service.Interfaces
{
	public interface IActivityService
	{
		public void Create(string name, int categoryId);
		public void Read(int id);
		public void Delete(int id);
	}
}

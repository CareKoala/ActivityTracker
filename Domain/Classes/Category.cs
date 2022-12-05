namespace Domain.Classes
{
	public class Category
	{
		public int Id { get; set; }
		public string Description { get; set; } = string.Empty;

		public Category(int id, string description)
		{
			Id = id;
			Description = description;
		}
	}
}

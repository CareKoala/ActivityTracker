using ActivityTracker.Models.Activity;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace ActivityTracker.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ActivityController : ControllerBase
	{
		private readonly ActivityService _activityService;

		public ActivityController(ActivityService activityService)
		{
			_activityService = activityService;
		}

		[HttpPost(Name = "Create")]
		public CreateOutput Create(CreateInput input)
		{
			ValidateCreate(input);

			_activityService.Create(input.Name, input.CategoryId);

			CreateOutput output = new();

			return output;
		}

		private void ValidateCreate(CreateInput input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Name == null)
			{
				throw new ArgumentNullException("name");
			}
		}
	}
}
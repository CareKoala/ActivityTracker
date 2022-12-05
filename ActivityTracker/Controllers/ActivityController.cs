using ActivityTracker.Models.Activity;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace ActivityTracker.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ActivityController : ControllerBase
	{
		private readonly IActivityService _activityService;

		public ActivityController(IActivityService activityService)
		{
			_activityService = activityService;
		}

		[HttpPost(Name = "Create")]
		public CreateActivityOutput Create(CreateActivityInput input)
		{
			ValidateCreate(input);

			_activityService.Create(input.Name, input.CategoryId);

			CreateActivityOutput output = new();

			return output;
		}

		private void ValidateCreate(CreateActivityInput input)
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
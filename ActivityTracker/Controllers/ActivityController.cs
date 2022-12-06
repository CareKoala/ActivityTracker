using ActivityTracker.Models.Activity;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Models.Activity;

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

		/// <summary>
		/// Create a new activity to allow adding intervals to keep track on the entire timeusage of the activity.
		/// Activity requires a category.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("Create")]
		public CreateActivityOutput Create(CreateActivityInput input)
		{
			ValidateCreateInput(input);

			ActivityCreateModel acvitityCreateModel = _activityService.Create(input.Name, input.CategoryId);

			CreateActivityOutput output = new(acvitityCreateModel.Id, acvitityCreateModel.CategoryDescription, ResponseStatus.Success, errorMessage: null);

			return output;
		}

		private void ValidateCreateInput(CreateActivityInput input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
		}
	}
}
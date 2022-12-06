using ActivityTracker.Models.Activity;
using ActivityTracker.Models.Interval;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Models;

namespace ActivityTracker.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class IntervalController : ControllerBase
	{
		private readonly IIntervalService _intervalService;

		public IntervalController(IIntervalService intervalService)
		{
			_intervalService = intervalService;
		}

		/// <summary>
		/// Create a new activity to allow adding intervals to keep track on the entire timeusage of the activity.
		/// Activity requires a category.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[HttpPost]
		[Route("Create")]
		public CreateIntervalOutput Create(CreateIntervalInput input)
		{
			ValidateCreateInput(input);

			bool isThereAnIntervalActive = _intervalService.IsIntervalActiveOnActivity(input.ActivityId);

			CreateIntervalOutput output;

			if (!isThereAnIntervalActive)
			{
				IntervalModel intervalModel = _intervalService.Create(input.ActivityId);

				//This should be moved to a private method instead of being dublicated here.
				output = new CreateIntervalOutput
				{
					Id = intervalModel.Id,
					IntervalStartInstant = intervalModel.IntervalStartInstant.ToString("G"),
					StatusMessage = Models.Activity.ResponseStatus.Success.ToString()
				};
			}
			else
			{
				output = new CreateIntervalOutput
				{
					StatusMessage = Models.Activity.ResponseStatus.Error.ToString(),
					ErrorMessage = "There is already an interval active for activity. Please stop interval to initiate a new one."
				};
			}

			return output;
		}

		[HttpPost]
		[Route("Update")]
		public UpdateIntervalOutput Update(UpdateIntervalInput input)
		{
			UpdateIntervalOutput output = new();

			bool isIntervalAvailableToUpdate = _intervalService.IsIntervalActiveOnActivity(input.ActivityId);

			if (isIntervalAvailableToUpdate)
			{
				_intervalService.EndInterval(input.Id, input.ActivityId, input.Description);

				output.StatusMessage = Models.Activity.ResponseStatus.Success.ToString();
			} else
			{
				output.StatusMessage = Models.Activity.ResponseStatus.Error.ToString();
				output.ErrorMessage = "There is no interval active on the activity.";
			}

			

			return output;
		}

		private void ValidateCreateInput(CreateIntervalInput input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
		}
	}
}
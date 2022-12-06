using ActivityTracker.Models.Activity;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

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

			_intervalService.Create();

			CreateIntervalOutput output = new();

			return output;
		}

		private void ValidateCreateInput(CreateIntervalInput input)
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
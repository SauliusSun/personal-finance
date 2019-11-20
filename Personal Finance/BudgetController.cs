using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalFinance.Extensions;

namespace PersonalFinance
{
	[ApiController]
	[Route("api/[controller]")]
	public class BudgetController : ControllerBase
	{
		[HttpPost]
		[Route("[action]")]
		public IActionResult Calculate(IFormFile file)
		{
			var lines = file.ToLines();
			return Ok(lines);
		}
	}
}

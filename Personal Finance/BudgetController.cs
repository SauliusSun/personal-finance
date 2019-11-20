using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Personal_Finance
{
	[ApiController]
	[Route("api/[controller]")]
	public class BudgetController : ControllerBase
    {
		[HttpPost]
		[Route("[action]")]
		public IActionResult Calculate(IFormFile file)
        {
			return Ok("empty");
        }
    }
}

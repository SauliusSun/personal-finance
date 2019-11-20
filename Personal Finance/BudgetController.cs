using Microsoft.AspNetCore.Mvc;

namespace Personal_Finance
{
	[ApiController]
	[Route("api/[controller]")]
	public class BudgetController : ControllerBase
    {
		[Route("[action]")]
        public ActionResult Calculate()
        {
			return Ok("empty");
        }
    }
}

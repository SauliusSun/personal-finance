using Microsoft.AspNetCore.Mvc;

namespace Personal_Finance
{
    [ApiController]
    [Route("api/[controller]")]
    public class BudgetController : ControllerBase
    {
        [Route("")]
        public ActionResult Get()
        {
            return Ok("Empty");
        }
    }
}

using System.Collections.Generic;
using System.Text.Json;
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
        [Consumes("multipart/form-data")]
        public IList<Category> Calculate([FromForm] BudgetRequest budgetRequest)
        {
            var file = budgetRequest.File;
			var lines = file.ToLines();
            var categories = JsonSerializer.Deserialize(
                budgetRequest.Categories, typeof(List<Category>),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) as List<Category>;
            var budget = new Budget();
            return budget.Calculate(lines, categories);
        }
	}
}

using Microsoft.AspNetCore.Http;

namespace PersonalFinance
{
    public class BudgetRequest
    {
        public IFormFile File { get; set; }
        public string Categories { get; set; }
    }
}

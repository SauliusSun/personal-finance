using System.Collections.Generic;
using System.Linq;

namespace PersonalFinance
{
	public class Category
	{
		public string Name { get; set; }
		public string[] Terms { get; set; }
        public decimal Sum => Transactions.Sum(t => t.Sum);
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

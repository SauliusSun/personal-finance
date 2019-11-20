using System.Collections.Generic;

namespace PersonalFinance
{
	public class Category
	{
		public string Name { get; set; }
		public string[] Labels { get; set; }
		public List<Transaction> Transactions { get; set; } = new List<Transaction>();

		public Category(string name, params string[] labels)
		{
			Name = name;
			Labels = labels;
		}
	}
}
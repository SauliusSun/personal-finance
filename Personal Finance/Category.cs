using System.Collections.Generic;
using System.Linq;

namespace PersonalFinance
{
    public class Category
    {
        public Category()
        {
        }

        public Category(string name, ICollection<Transaction> transactions)
        {
            Name = name;
            Transactions = transactions;
        }

        public string Name { get; set; }
        public string[] Terms { get; set; }
        public decimal Sum => Transactions.Sum(t => t.Sum);
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

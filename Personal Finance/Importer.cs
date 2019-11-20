using System.Collections.Generic;
using System.IO;

namespace PersonalFinance
{
	public class Importer
	{
		private const char Seperator = ';';
		private static readonly string Path = "C:\\Users\\sauli\\Desktop\\Personal finance\\default_layout.csv";
		private readonly List<Category> categories = new List<Category> { new Category("Bank", "Luminor Bank AB") };

		public List<Category> Parse()
		{
			//var file = File.ReadAllLines(Path, Encoding.GetEncoding("windows-1257"));
			var fileLines = File.ReadAllLines(Path);
			var transactions = ConvertToTransactions(fileLines);

			foreach (var category in categories)
			{
				foreach (var label in category.Labels)
				{
					foreach (var transaction in transactions)
					{
						if (transaction.ReceiverName.Contains(label, System.StringComparison.InvariantCultureIgnoreCase))
						{
							category.Transactions.Add(transaction);
							transactions.Remove(transaction);
						}
					}
				}
			}

			return categories;
		}

		private static List<Transaction> ConvertToTransactions(string[] fileLines)
		{
			var transactions = new List<Transaction>();
			foreach (var fileLine in fileLines)
			{
				string[] lineFields = fileLine.Split(Seperator);
				var transaction = new Transaction
				{
					AccountNumber = lineFields[0],
					OperationDate = lineFields[1],
					CurrencyExchangeDate = lineFields[2],
					PaymentNumber = lineFields[3],
					ReceiverAccountNumber = lineFields[4],
					ReceiverName = lineFields[5],
					DebitOrCredit = lineFields[6],
					Sum = lineFields[7],
					PayerCode = lineFields[8],
					BankLink = lineFields[9],
					OperationDetails = lineFields[10],
					Currency = lineFields[11],
					PersonOrCompanyCode = lineFields[12],
					AccountBalance = lineFields[13],
					PaymentCode = lineFields[14]
				};

				transactions.Add(transaction);
			}

			return transactions;
		}
	}
}

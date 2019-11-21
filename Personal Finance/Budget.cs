using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PersonalFinance
{
	public class Budget
	{
		public IList<Category> Calculate(IList<string> lines, IList<Category> categories)
		{
			var transactions = CreateTransactions(lines);

			foreach (var transaction in transactions)
			{
				var categoryFound = categories
					.FirstOrDefault(category => category.Terms
						.Any(term => transaction.ReceiverName
							.Contains(term, StringComparison.InvariantCultureIgnoreCase)));
				categoryFound?.Transactions.Add(transaction);
			}

			return categories;
		}

		private static IEnumerable<Transaction> CreateTransactions(IEnumerable<string> lines)
		{
			return lines.Skip(1).Select(line => line.Split("\";\""))
				.Select(lineFields => new Transaction
				{
					AccountNumber = lineFields[0],
					OperationDate = lineFields[1],
					CurrencyExchangeDate = lineFields[2],
					PaymentNumber = lineFields[3],
					ReceiverAccountNumber = lineFields[4],
					ReceiverName = lineFields[5],
					DebitOrCredit = lineFields[6],
					Sum = decimal.TryParse(lineFields[7].Trim('"').Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out var sum) ? sum : 0,
					PayerCode = lineFields[8],
					BankLink = lineFields[9],
					OperationDetails = lineFields[10],
					Currency = lineFields[11],
					PersonOrCompanyCode = lineFields[12],
					AccountBalance = lineFields[13],
					PaymentCode = lineFields[14]
				});
		}
	}
}

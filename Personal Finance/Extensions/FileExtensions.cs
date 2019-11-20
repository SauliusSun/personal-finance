using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;

namespace PersonalFinance.Extensions
{
	public static class FileExtensions
	{
		public static IList<string> ToLines(this IFormFile file)
		{
			var lines = new List<string>();
			using (var streamReader = new StreamReader(file.OpenReadStream()))
				while (streamReader.Peek() >= 0)
					lines.Add(streamReader.ReadLine());
			return lines;
		}
	}
}

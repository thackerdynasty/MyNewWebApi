using System;
using System.IO;
//using CsvHelper;
namespace MyNewWebApi.Models
{
	public class SeedData
	{
		public SeedData()
		{
			using (var reader = new StreamReader("pokemon.csv"));
			//using (var csv = new CsvReader()) ;
		}
	}
}


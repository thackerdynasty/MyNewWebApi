using System;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using System.IO;
using CsvHelper;
namespace MyNewWebApi.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider provider) 
		{
			using (var context = new AppDBContext(provider.GetRequiredService<DbContextOptions<AppDBContext>>()))
			{
				if (context.Pokemons.Any())
				{
					return;
				}
				using (var reader = new StreamReader("pokemon.csv"))
				using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
				{
					var records = csv.GetRecords<Pokemon>();
					context.Pokemons.AddRange(records);
					context.SaveChanges();
				}
			}
		}
	}
}


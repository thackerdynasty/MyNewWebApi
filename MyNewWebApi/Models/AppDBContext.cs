using System;
using Microsoft.EntityFrameworkCore;
namespace MyNewWebApi.Models
{
	public class AppDBContext : DbContext
	{
		public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
		{
		}
		public DbSet<Pokemon> Pokemons { get; set; }
	}
}


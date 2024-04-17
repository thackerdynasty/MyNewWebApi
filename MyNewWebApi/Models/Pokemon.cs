using System;
using System.ComponentModel.DataAnnotations;
namespace MyNewWebApi.Models
{
	public class Pokemon
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
		
		[Required]
		public string Type { get; set; }

		public string Type2 { get; set; }

		[Required]
		public int Hp { get; set; }

		[Required]
		public int Attack { get; set; }

		[Required]
		public int Defense { get; set; }

		[Required]
		public int SpeedAttack { get; set; }

		[Required]
		public int SpeedDefense { get; set; }

		[Required]
		public int Speed { get; set; }

		[Required]
		public bool Legendary { get; set; }
	}
}


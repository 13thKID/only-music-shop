using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlyMusicShop.Infrastructue.Repositories.Requests
{
	public class CreateGuitarRequest
	{
		public int Id { get; set; }
		[Required]
		public required string Name { get; set; }
		[Required]
		public required string Manufacturer { get; set; }
		public required string Model { get; set; }
		public required string Type { get; set; }
		public required string Color { get; set; }
		public string? Description { get; set; }
		public required decimal Price { get; set; }
	}
}

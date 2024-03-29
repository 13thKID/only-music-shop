﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyMusicShop.Domain.Entities
{
	public class Guitar
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Manufacturer { get; set; }
		public required string Model { get; set; }
		public required string Type { get; set; }
		public required string Color { get; set; }
		public string? Description { get; set; }
		public required decimal Price { get; set; }
		public DateTime? CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}
}

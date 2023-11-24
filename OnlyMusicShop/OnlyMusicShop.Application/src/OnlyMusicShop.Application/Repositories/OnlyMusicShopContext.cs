using Microsoft.EntityFrameworkCore;
using OnlyMusicShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyMusicShop.Application.Repositories
{
	internal class OnlyMusicDbContext : DbContext
	{
		public DbSet<Guitar> Guitars { get; set; }
	}
}
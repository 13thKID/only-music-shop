using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Application;
using System.Reflection.Metadata;

namespace OnlyMusicShop.Application.Repositories
{
	public class GuitarAttributes
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Manufacturer { get; set; }
		public required string Model { get; set; }
		public required string Type { get; set; }
		public required string Color { get; set; }
		public string? Description { get; set; }
		public required decimal Price { get; set; }
	}
	public class GuitarRepository:IGuitarRepository
    {
		private readonly OnlyMusicDbContext _db;

		public GuitarRepository(OnlyMusicDbContext db)
		{
			_db = db ?? throw new ArgumentNullException(nameof(db));
		}
		public List<Guitar> GetGuitars()
		{
			var guitars = _db.Guitars.ToList();

			return guitars;
		}

		public Guitar GetGuitar(int id)
		{
			var guitar = _db.Guitars
					.Where(b => b.Id == id)
					.FirstOrDefault();
			return guitar;
		}

		public Guitar CreateGuitar(GuitarAttributes attr)
		{
			var guitar = new Guitar() {
				Id = attr.Id,
				Name = attr.Name,
				Manufacturer = attr.Manufacturer,
				Model = attr.Model,
				Type = attr.Type,
				Color = attr.Color,
				Description = attr.Description,
				Price = (decimal)attr.Price,
			};

			_db.Add<Guitar>(guitar);
			_db.SaveChanges();

			return guitar;
		}

		public int RemoveGuitar(int id)
		{
			_db.Remove(_db.Guitars.Single(a => a.Id == id));
			_db.SaveChanges();

			return id;
		}

		public Guitar UpdateGuitar(int id, GuitarAttributes attr)
		{
			var guitar = _db.Guitars.Where(g => g.Id == id).First();

			guitar.Name = attr.Name;
			guitar.Manufacturer = attr.Manufacturer;
			guitar.Model = attr.Model;
			guitar.Type = attr.Type;
			guitar.Color = attr.Color;
			guitar.Description = attr.Description;
			guitar.Price = attr.Price;

			_db.SaveChanges();

			return guitar;
		}
	}
}


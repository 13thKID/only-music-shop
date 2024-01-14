﻿using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Infrastructue;
using System.Reflection.Metadata;
using OnlyMusicShop.Infrastructue.Repositories.Requests;

namespace OnlyMusicShop.Infrastructue.Repositories
{
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

		public Guitar CreateGuitar(CreateGuitarRequest attr)
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

		public Guitar UpdateGuitar(int id, CreateGuitarRequest attr)
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

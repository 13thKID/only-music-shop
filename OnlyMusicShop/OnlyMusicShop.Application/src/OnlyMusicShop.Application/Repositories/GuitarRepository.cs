using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Repositories

{
    public class GuitarRepository:IGuitarRepository
    {
        public List<Guitar> GetGuitars()
        {
            return new List<Guitar>()
            {
                new() { Id = 1, Name = "Fender Stratocaster", Price = 299.99M }
            };
        }

        public Guitar GetGuitar(int id)
        {
            return new Guitar() { Id = id, Name = "Gibson 355 Cherry", Price = 2999M };
        }
    }
}


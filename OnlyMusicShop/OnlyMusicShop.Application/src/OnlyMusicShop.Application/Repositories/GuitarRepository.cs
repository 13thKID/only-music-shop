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
    }
}

public class Guitar
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

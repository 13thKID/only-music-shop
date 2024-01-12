using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Repositories;

public interface IGuitarRepository
{
    public List<Guitar> GetGuitars();
    public Guitar GetGuitar(int id);
    public Guitar CreateGuitar(GuitarAttributes attr);
    public int RemoveGuitar(int id);
    public Guitar UpdateGuitar(int id, GuitarAttributes attr);
}
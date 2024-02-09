using OnlyMusicShop.Application.Requests;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Interfaces;

public interface IGuitarRepository
{
    public List<Guitar> GetGuitars();
    public Guitar GetGuitar(int id);
    public Guitar CreateGuitar(CreateGuitarRequest attr);
    public int RemoveGuitar(int id);
    public Guitar UpdateGuitar(int id, CreateGuitarRequest attr);
}
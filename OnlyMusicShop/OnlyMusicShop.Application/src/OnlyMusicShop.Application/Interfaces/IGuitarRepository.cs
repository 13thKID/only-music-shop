using OnlyMusicShop.Application.Requests;
using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Interfaces;

public interface IGuitarRepository
{
    public List<Guitar> GetGuitars();
    public Guitar GetGuitar(int id);
    public Guitar CreateGuitar(CreateGuitarRequest attr);
    public Guitar RemoveGuitar(int id);
    public Guitar UpdateGuitar(int id, UpdateGuitarRequest attr);
}
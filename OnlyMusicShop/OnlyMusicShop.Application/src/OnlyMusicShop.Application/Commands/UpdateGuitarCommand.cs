using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Requests;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Commands
{
	public sealed record UpdateGuitarCommand(int Id, UpdateGuitarRequest GuitarBody) : ICommand<Guitar>;
}

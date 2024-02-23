using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Requests;

namespace OnlyMusicShop.Application.Commands
{
	public sealed record CreateGuitarCommand(CreateGuitarRequest GuitarBody) : ICommand;
}

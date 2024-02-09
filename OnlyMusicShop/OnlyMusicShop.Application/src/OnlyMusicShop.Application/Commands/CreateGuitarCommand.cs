using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Requests;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Commands
{
	public record CreateGuitarCommand(CreateGuitarRequest GuitarBody) : IRequest<Guitar>;
}

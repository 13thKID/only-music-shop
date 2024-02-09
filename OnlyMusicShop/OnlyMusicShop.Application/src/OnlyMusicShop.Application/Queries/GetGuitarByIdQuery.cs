using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Queries
{
	public record GetGuitarByIdQuery(int Id) : IRequest<Guitar>;
}

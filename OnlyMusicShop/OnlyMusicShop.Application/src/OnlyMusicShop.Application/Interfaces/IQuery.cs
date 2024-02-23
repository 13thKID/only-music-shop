using MediatR;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Interfaces
{
	public interface IQuery<TResponse> : IRequest<Result<TResponse>>
	{ }
}

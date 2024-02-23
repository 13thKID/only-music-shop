using MediatR;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Interfaces
{
	public interface ICommand : IRequest<Result>
	{ }

	public interface ICommand<TResponse> : IRequest<Result<TResponse>>
	{ }
}

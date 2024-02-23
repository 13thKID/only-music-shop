using MediatR;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Interfaces
{
	public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
		where TQuery : IQuery<TResponse>
	{
	}
}

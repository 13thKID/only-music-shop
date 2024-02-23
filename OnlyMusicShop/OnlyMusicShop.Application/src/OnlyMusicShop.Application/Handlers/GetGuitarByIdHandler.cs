using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Handlers
{
	public class GetGuitarByIdHandler : IQueryHandler<GetGuitarByIdQuery, Guitar>
	{
		private readonly IGuitarRepository _guitarRepository;

		public GetGuitarByIdHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public Task<Result<Guitar>> Handle(GetGuitarByIdQuery request, CancellationToken cancellationToken)
		{
			var guitar = _guitarRepository.GetGuitar(request.Id);

			if (guitar is null)
			{
				return Task.FromResult(Result.Failure<Guitar>(new Error("Guitar.NotFound", "Not found")));
			}

			return Task.FromResult(Result.Success(guitar));

		}
	}
}

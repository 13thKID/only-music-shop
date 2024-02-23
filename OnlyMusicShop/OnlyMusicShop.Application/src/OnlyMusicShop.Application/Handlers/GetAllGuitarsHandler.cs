using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Handlers
{
	// IRequestHandler<"what am I handling","what the output is gonna be?">
	public class GetAllGuitarsHandler : IQueryHandler<GetAllGuitarsQuery, List<Guitar>>
	{
		private readonly IGuitarRepository _guitarRepository;

		public GetAllGuitarsHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public Task<Result<List<Guitar>>> Handle(GetAllGuitarsQuery request, CancellationToken cancellationToken)
		{
			var guitars = _guitarRepository.GetGuitars();

			if (guitars.Any())
			{
				return Task.FromResult(Result.Success(guitars));
			};

			return Task.FromResult(Result.Failure<List<Guitar>>(new Error("Guitar.NotFound", "Not found")));
		}
	}
}

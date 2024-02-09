using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Handlers
{
	// IRequestHandler<"what am I handling","what the output is gonna be?">
	public class GetAllGuitarsHandler : IRequestHandler<GetAllGuitarsQuery, List<Guitar>>
	{
		private readonly IGuitarRepository _guitarRepository;

		public GetAllGuitarsHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public Task<List<Guitar>> Handle(GetAllGuitarsQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_guitarRepository.GetGuitars());
		}
	}
}

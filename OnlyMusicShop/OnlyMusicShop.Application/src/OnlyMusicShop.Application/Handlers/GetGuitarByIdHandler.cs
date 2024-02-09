using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Handlers
{
	public class GetGuitarByIdHandler : IRequestHandler<GetGuitarByIdQuery, Guitar>
	{
		private readonly IGuitarRepository _guitarRepository;

		public GetGuitarByIdHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public Task<Guitar> Handle(GetGuitarByIdQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_guitarRepository.GetGuitar(request.Id));
		}
	}
}

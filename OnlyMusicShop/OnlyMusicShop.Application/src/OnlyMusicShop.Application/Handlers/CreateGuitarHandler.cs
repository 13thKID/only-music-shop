using MediatR;
using OnlyMusicShop.Application.Commands;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Handlers
{
	public class CreateGuitarHandler : IRequestHandler<CreateGuitarCommand, Guitar>
	{
		private readonly IGuitarRepository _guitarRepository;

		public CreateGuitarHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public Task<Guitar> Handle(CreateGuitarCommand request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_guitarRepository.CreateGuitar(request.GuitarBody));
		}
	}
}

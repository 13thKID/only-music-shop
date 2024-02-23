using MediatR;
using OnlyMusicShop.Application.Commands;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Handlers
{
	public sealed class CreateGuitarHandler : ICommandHandler<CreateGuitarCommand>
	{
		private readonly IGuitarRepository _guitarRepository;

		public CreateGuitarHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public async Task<Result> Handle(CreateGuitarCommand request, CancellationToken cancellationToken)
		{
			//return Task.FromResult(_guitarRepository.CreateGuitar(request.GuitarBody));
			return Result.Success();
		}
	}
}

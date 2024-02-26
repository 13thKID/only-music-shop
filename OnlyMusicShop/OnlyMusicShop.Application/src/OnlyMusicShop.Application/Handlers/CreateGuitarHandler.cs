using MediatR;
using OnlyMusicShop.Application.Commands;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Handlers
{
	public sealed class CreateGuitarHandler : ICommandHandler<CreateGuitarCommand, Guitar>
	{
		private readonly IGuitarRepository _guitarRepository;

		public CreateGuitarHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public Task<Result<Guitar>> Handle(CreateGuitarCommand request, CancellationToken cancellationToken)
		{
			var newGuitar = _guitarRepository.CreateGuitar(request.GuitarBody);

			if(newGuitar is not null)
			{
				return Task.FromResult(Result.Success(newGuitar)); ;
			}  else
			{
				return Task.FromResult(Result.Failure<Guitar>(new Error("Guitar.NotCreated", "The guitar could not be created")));
			}
		}
	}
}

using MediatR;
using OnlyMusicShop.Application.Commands;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Handlers
{
	public sealed class UpdateGuitarHandler : ICommandHandler<UpdateGuitarCommand, Guitar>
	{
		private readonly IGuitarRepository _guitarRepository;

		public UpdateGuitarHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public Task<Result<Guitar>> Handle(UpdateGuitarCommand request, CancellationToken cancellationToken)
		{
			var newGuitar = _guitarRepository.UpdateGuitar(request.Id, request.GuitarBody);

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

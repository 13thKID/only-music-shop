using MediatR;
using OnlyMusicShop.Application.Commands;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Handlers
{
	public sealed class DeleteGuitarHandler : ICommandHandler<DeleteGuitarCommand, Guitar>
	{
		private readonly IGuitarRepository _guitarRepository;

		public DeleteGuitarHandler(IGuitarRepository guitarRepository)
		{
			_guitarRepository = guitarRepository;
		}

		public Task<Result<Guitar>> Handle(DeleteGuitarCommand request, CancellationToken cancellationToken)
		{
			var removedGuitar = _guitarRepository.RemoveGuitar(request.guitarId);

			if(removedGuitar is not null)
			{
				return Task.FromResult(Result.Success(removedGuitar));
			} else
			{
				return Task.FromResult(Result.Failure<Guitar>(new Error("Guitar.NotFound", "Not found")));
			}
			
		}
	}
}

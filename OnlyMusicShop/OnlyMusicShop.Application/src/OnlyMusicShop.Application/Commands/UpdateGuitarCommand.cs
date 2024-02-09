using MediatR;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Application.Requests;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Commands
{
	//public class CreateGuitarCommand : IRequest<Guitar>
	//{
	//	public CreateGuitarRequest GuitarBody { get; set; }

	//	public CreateGuitarCommand(CreateGuitarRequest requestBody)
	//	{
	//		GuitarBody = requestBody;
	//	}
	//}

	//public class CreateGuitarCommandHandler : IRequestHandler<CreateGuitarCommand, Guitar>
	//{
	//	private readonly IGuitarRepository _guitarRepository;

	//	public CreateGuitarCommandHandler(IGuitarRepository guitarRepository)
 //       {
	//		_guitarRepository = guitarRepository;
	//	}

 //       public Task<Guitar> Handle(CreateGuitarCommand request, CancellationToken cancellationToken)
	//	{
	//		return Task.FromResult(_guitarRepository.CreateGuitar(request.GuitarBody));
	//	}
	//}
}

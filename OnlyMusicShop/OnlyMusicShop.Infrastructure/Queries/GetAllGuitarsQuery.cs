using MediatR;
using OnlyMusicShop.Infrastructue.Repositories;
using OnlyMusicShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyMusicShop.Infrastructue.Queries
{
	public class GetAllGuitarsQuery: IRequest<List<Guitar>>
	{
	}

	public class GetAllGuitarsQueryHandler : IRequestHandler<GetAllGuitarsQuery, List<Guitar>>
	{
		private readonly IGuitarRepository _guitarRepository;

		public GetAllGuitarsQueryHandler(IGuitarRepository guitarRepository)
        {
			_guitarRepository = guitarRepository;
		}

        public Task<List<Guitar>> Handle(GetAllGuitarsQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_guitarRepository.GetGuitars());
		}
	}
}

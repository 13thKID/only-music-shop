using MediatR;
using OnlyMusicShop.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyMusicShop.Application.Interfaces
{
	public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
		where TCommand : ICommand
	{}

	public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
		where TCommand : ICommand<TResponse>
	{ }
}

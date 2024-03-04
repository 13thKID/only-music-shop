using FluentValidation;

using OnlyMusicShop.Application.Commands;

namespace OnlyMusicShop.Application.Validators
{
	public class UpdateGuitarCommandValidator: AbstractValidator<UpdateGuitarCommand>
	{
		public UpdateGuitarCommandValidator()
		{
			RuleFor(x => x.GuitarBody.Color).NotEmpty();
		}
	}
}

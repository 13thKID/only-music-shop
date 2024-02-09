using FluentValidation;

using OnlyMusicShop.Application.Commands;

namespace OnlyMusicShop.Application.Validators
{
	public class CreateGuitarCommandValidator: AbstractValidator<CreateGuitarCommand>
	{
		public CreateGuitarCommandValidator()
		{
			RuleFor(x => x.GuitarBody).NotEmpty();
			RuleFor(x => x.GuitarBody.Color).NotEmpty();
		}
	}
}

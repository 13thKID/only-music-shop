﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyMusicShop.Domain.Shared
{
	public sealed class ValidationResult: Result
	{
		private ValidationResult(Error[] errors)
			: base(false, IValidationResult.ValidationError) =>
			Errors = errors;

		public Error[] Errors { get; }

		public static ValidationResult WithErrors(Error[] errors) => new(errors);
	}
}
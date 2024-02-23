﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OnlyMusicShop.Domain.Shared
{
	public record Error(string Code, string Message)
	{
		public static readonly Error None = new(string.Empty, string.Empty);

		public static readonly Error NullValue = new("Error.NullValue", "The specified result value is null.");

		public static readonly Error ConditionNotMet = new("Error.ConditionNotMet", "The specified condition was not met.");
	}
}

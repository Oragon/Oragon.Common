// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;
using System.Linq;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		public static bool NotContains<T>(this IEnumerable<T> @this, Func<T, bool> predicate)
		{
			return !@this.Any(predicate);
		}

		#endregion Public Methods
	}
}
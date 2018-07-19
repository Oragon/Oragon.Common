// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>04A869C9-C538-435B-A75C-EF4793E7E8D4</id>
		/// <summary>
		///     A DateTime extension method that query if '@this' is a week day.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if '@this' is a week day, false if not.</returns>
		public static bool IsWeekDay(this DateTime @this)
		{
			return !(@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
		}

		#endregion Public Methods
	}
}
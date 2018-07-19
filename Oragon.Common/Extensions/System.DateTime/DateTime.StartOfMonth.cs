// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>08493F86-5D63-4BA3-826A-25A9CF4545D5</id>
		/// <summary>
		///     A DateTime extension method that return a DateTime of the first day of the month with the time set to "00:00:00". The first moment of
		///     the day.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>A DateTime of the first day of the month with the time set to "00:00:00".</returns>
		public static DateTime StartOfMonth(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, 1);
		}

		#endregion Public Methods
	}
}
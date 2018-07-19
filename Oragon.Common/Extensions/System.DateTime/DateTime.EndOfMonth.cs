// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>A761EBA2-B2B5-4423-8BA4-45DD170DCD5D</id>
		/// <summary>
		///     A DateTime extension method that return a DateTime of the last day of the month with the time set to "23:59:59". The last moment of
		///     the day.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>A DateTime of the last day of the month with the time set to "23:59:59:999".</returns>
		public static DateTime EndOfMonth(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, 1).AddMonths(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
		}

		#endregion Public Methods
	}
}
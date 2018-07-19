// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>83197779-D3C5-482B-82ED-B9992801C430</id>
		/// <summary>
		///     A DateTime extension method that query if '@this' is a weekend day.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if '@this' is a weekend day, false if not.</returns>
		public static bool IsWeekendDay(this DateTime @this)
		{
			return (@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
		}

		#endregion Public Methods
	}
}
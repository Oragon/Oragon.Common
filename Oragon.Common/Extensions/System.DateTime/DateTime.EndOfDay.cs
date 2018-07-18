// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>A9DB7F39-68F3-4D7F-91ED-BA3A09AE46E7</id>
		/// <summary>
		///     A DateTime extension method that return a DateTime with the time set to "23:59:59:999". The last moment of the day.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>A DateTime of the day with the time set to "23:59:59".</returns>
		public static DateTime EndOfDay(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
		}

		#endregion Public Methods
	}
}
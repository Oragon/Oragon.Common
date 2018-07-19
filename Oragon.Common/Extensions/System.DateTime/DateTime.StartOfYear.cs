// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>38C24938-FB6F-4E82-ABE6-E717AAD74CA8</id>
		/// <summary>
		///     A DateTime extension method that return a DateTime of the first day of the year with the time set to "00:00:00". The first moment of
		///     the day.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>A DateTime of the first day of the year with the time set to "00:00:00".</returns>
		public static DateTime StartOfYear(this DateTime @this)
		{
			return new DateTime(@this.Year, 1, 1);
		}

		#endregion Public Methods
	}
}
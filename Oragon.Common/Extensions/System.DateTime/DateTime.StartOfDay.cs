// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>527916DE-B3C5-451B-A50B-E1EC6734A568</id>
		/// <summary>
		///     A DateTime extension method that return a DateTime with the time set to "00:00:0". The first moment of the day.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>A DateTime of the day with the time set to "00:00:00".</returns>
		public static DateTime StartOfDay(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, @this.Day);
		}

		#endregion Public Methods
	}
}
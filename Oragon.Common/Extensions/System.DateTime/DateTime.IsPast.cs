// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>A7FFEED4-7D2A-4923-BE26-CEDDC5692A5E</id>
		/// <summary>
		///     A DateTime extension method that query if '@this' is in the past.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if the value is in the past, false if not.</returns>
		public static bool IsPast(this DateTime @this)
		{
			return @this < DateTime.Now;
		}

		#endregion Public Methods
	}
}
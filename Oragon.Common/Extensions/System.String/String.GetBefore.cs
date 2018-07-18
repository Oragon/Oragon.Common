// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>74A42366-148D-46AA-97A2-CC888CFF4C8B</id>
		/// <summary>
		///     A string extension method that get the string before the specified string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="value">The value to search.</param>
		/// <returns>The string before the specified value.</returns>
		public static string GetBefore(this string @this, string value)
		{
			int startIndex = @this.IndexOf(value);
			return startIndex == -1 ? String.Empty : @this.Substring(0, startIndex);
		}

		#endregion Public Methods
	}
}
// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>685006BD-7D08-4F4D-B5C7-EF766CCD6294</id>
		/// <summary>
		///     A string extension method that get the string between the two specified string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="before">The string before to search.</param>
		/// <param name="after">The string after to search.</param>
		/// <returns>The string between the two specified string.</returns>
		public static string GetBetween(this string @this, string before, string after)
		{
			int beforeStartIndex = @this.IndexOf(before);
			int startIndex = beforeStartIndex + before.Length;
			int afterStartIndex = @this.IndexOf(after);

			if (beforeStartIndex == -1 || beforeStartIndex == -1 || afterStartIndex < beforeStartIndex)
			{
				return String.Empty;
			}

			return @this.Substring(startIndex, afterStartIndex - startIndex);
		}

		#endregion Public Methods
	}
}
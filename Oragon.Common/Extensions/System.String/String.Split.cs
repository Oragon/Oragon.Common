// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>9B1E1652-78CD-484A-8F31-85ED53FEB84C</id>
		/// <summary>
		///     Returns a String array containing the substrings in this string that are delimited by elements of a specified String array. A
		///     parameter specifies whether to return empty array elements.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="separator">A string that delimit the substrings in this string.</param>
		/// <param name="option">
		///     (Optional) Specify RemoveEmptyEntries to omit empty array elements from the array returned, or None to include empty array elements in
		///     the array returned.
		/// </param>
		/// <returns>An array whose elements contain the substrings in this string that are delimited by the separator.</returns>
		public static string[] Split(this string @this, string separator, StringSplitOptions option = StringSplitOptions.None)
		{
			return @this.Split(new[] { separator }, option);
		}

		#endregion Public Methods
	}
}
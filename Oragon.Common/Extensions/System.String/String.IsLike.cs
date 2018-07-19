// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Text.RegularExpressions;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>A4B1426C-E86C-4D2A-9509-68BC55958B03</id>
		/// <summary>
		///     A string extension method that query if '@this' satisfy the specified pattern.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="pattern">Specifies the pattern. Use '*' as wildcard string.</param>
		/// <returns>true if '@this' satisfy the specified pattern, false if not.</returns>
		public static bool IsLike(this string @this, string pattern)
		{
			// Turn the pattern into regex pattern, and match the whole string with ^$
			string regexPattern = "^" + Regex.Escape(pattern) + "$";

			// Escape special character ?, #, *, [], and [!]
			regexPattern = regexPattern.Replace(@"\[!", "[^")
				.Replace(@"\[", "[")
				.Replace(@"\]", "]")
				.Replace(@"\?", ".")
				.Replace(@"\*", ".*")
				.Replace(@"\#", @"\d");

			return Regex.IsMatch(@this, regexPattern);
		}

		#endregion Public Methods
	}
}
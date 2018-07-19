// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Text.RegularExpressions;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>D8790C50-101F-44BA-8F7D-4723DFA0B0FF</id>
		/// <summary>
		///     A string extension method that query if '@this' is Alphanumeric.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if Alphanumeric, false if not.</returns>
		public static bool IsAlphaNumeric(this string @this)
		{
			return !Regex.IsMatch(@this, "[^a-zA-Z0-9]");
		}

		#endregion Public Methods
	}
}
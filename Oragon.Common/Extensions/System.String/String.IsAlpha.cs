// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Text.RegularExpressions;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>7D1901DF-B086-4623-81B6-494A618E0E0D</id>
		/// <summary>
		///     A string extension method that query if '@this' is Alpha.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if Alpha, false if not.</returns>
		public static bool IsAlpha(this string @this)
		{
			return !Regex.IsMatch(@this, "[^a-zA-Z]");
		}

		#endregion Public Methods
	}
}
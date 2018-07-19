// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>EBD9B7B5-0B56-4868-9A62-04A9DF560D5E</id>
		/// <summary>
		///     A string extension method that query if this object contains the given value.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="value">The value.</param>
		/// <returns>true if the value is in the string, false if not.</returns>
		public static bool Contains(this string @this, string value)
		{
			return @this.IndexOf(value) != -1;
		}

		/// <id>9BE70BB5-D755-40EB-9733-94DA54E461F3</id>
		/// <summary>
		///     A string extension method that query if this object contains the given value.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="value">The value.</param>
		/// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
		/// <returns>true if the value is in the string, false if not.</returns>
		public static bool Contains(this string @this, string value, StringComparison comparisonType)
		{
			return @this.IndexOf(value, comparisonType) != -1;
		}

		#endregion Public Methods
	}
}
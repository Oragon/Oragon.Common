// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>1B45ADFA-3C9D-4A5C-ACF3-4124147F3657</id>
		/// <summary>
		///     A string extension method that query if '@this' contains any values.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		/// <returns>true if it contains any values, otherwise false.</returns>
		public static bool ContainsAny(this string @this, params string[] values)
		{
			foreach (string value in values)
			{
				if (@this.IndexOf(value) != -1)
				{
					return true;
				}
			}
			return false;
		}

		/// <id>A261555F-8A76-4BA6-A6C1-78619056A17D</id>
		/// <summary>
		///     A string extension method that query if '@this' contains any values.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="comparisonType">Type of the comparison.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		/// <returns>true if it contains any values, otherwise false.</returns>
		public static bool ContainsAny(this string @this, StringComparison comparisonType, params string[] values)
		{
			foreach (string value in values)
			{
				if (@this.IndexOf(value, comparisonType) != -1)
				{
					return true;
				}
			}
			return false;
		}

		#endregion Public Methods
	}
}
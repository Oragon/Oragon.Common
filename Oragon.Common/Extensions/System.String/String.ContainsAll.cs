// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>D42CB5CB-3C08-431B-A376-AA3C7A70271C</id>
		/// <summary>
		///     A string extension method that query if '@this' contains all values.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		/// <returns>true if it contains all values, otherwise false.</returns>
		public static bool ContainsAll(this string @this, params string[] values)
		{
			foreach (string value in values)
			{
				if (@this.IndexOf(value) == -1)
				{
					return false;
				}
			}
			return true;
		}

		/// <id>92ED25BB-09EA-47AE-8A3F-3A8F3A569479</id>
		/// <summary>
		///     A string extension method that query if this object contains the given @this.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="comparisonType">Type of the comparison.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		/// <returns>true if the object is in this collection, false if not.</returns>
		public static bool ContainsAll(this string @this, StringComparison comparisonType, params string[] values)
		{
			foreach (string value in values)
			{
				if (@this.IndexOf(value, comparisonType) == -1)
				{
					return false;
				}
			}
			return true;
		}

		#endregion Public Methods
	}
}
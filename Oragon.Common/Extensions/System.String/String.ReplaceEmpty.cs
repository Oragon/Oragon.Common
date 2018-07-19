// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>C89C7A5D-7419-433A-8998-910D011A6D86</id>
		/// <summary>
		///     A string extension method that replace all values specified by an empty string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		/// <returns>A string with all specified values replaced by an empty string.</returns>
		public static string ReplaceEmpty(this string @this, params string[] values)
		{
			foreach (string value in values)
			{
				@this = @this.Replace(value, "");
			}

			return @this;
		}

		/// <id>19EBA9E1-3E0B-4ED1-AFE8-80C33C756FC9</id>
		/// <summary>
		///     A string extension method that replace all values specified by an empty string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		/// <returns>A string with all specified values replaced by an empty string.</returns>
		public static string ReplaceEmpty(this string @this, List<string> values)
		{
			foreach (string value in values)
			{
				@this = @this.Replace(value, "");
			}

			return @this;
		}

		#endregion Public Methods
	}
}
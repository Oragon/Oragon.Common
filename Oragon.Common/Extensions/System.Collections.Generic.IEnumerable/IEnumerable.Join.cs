// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>4C6147B5-7CCB-4E45-9611-11B86ADA8CB8</id>
		/// <summary>
		///     Concatenates all the elements of a IEnumerable, using the specified separator between each element.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">An IEnumerable that contains the elements to concatenate.</param>
		/// <param name="separator">
		///     The string to use as a separator. separator is included in the returned string only if value has more than one element.
		/// </param>
		/// <returns>
		///     A string that consists of the elements in value delimited by the separator string. If value is an empty array, the method returns String.Empty.
		/// </returns>
		public static string Join<T>(this IEnumerable<T> @this, string separator)
		{
			return string.Join(separator, @this);
		}

		#endregion Public Methods
	}
}
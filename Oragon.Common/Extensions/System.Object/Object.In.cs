// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>8B405D63-F5B5-4193-992D-5B2E703E2D15</id>
		/// <summary>
		///     A T extension method to determines whether the object is equal to any of the provided values.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The object to be compared.</param>
		/// <param name="values">The value list to compare with the object.</param>
		/// <returns>true if the values list contains the object, else false.</returns>
		/// <example>
		///     <code>
		///         var item = 1;
		///
		///         if(item.In(1, 2, 3))
		///         {
		///             // ...Code...
		///         }
		///     </code>
		/// </example>
		public static bool In<T>(this T @this, params T[] values)
		{
			return Array.IndexOf(values, @this) != -1;
		}

		/// <id>5E5B02F7-F65F-454F-8530-6917620F221A</id>
		/// <summary>
		///     A T extension method to determines whether the object is equal to any of the provided values.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The object to be compared.</param>
		/// <param name="values">The value list to compare with the object.</param>
		/// <returns>true if the values list contains the object, else false.</returns>
		/// <example>
		///     <code>
		///         var list = new List&lt;int&gt;() { 1, 2, 3 };
		///         var item = 1;
		///
		///         if(item.In(list))
		///         {
		///             // ...Code...
		///         }
		///     </code>
		/// </example>
		public static bool In<T>(this T @this, List<T> values)
		{
			return values.IndexOf(@this) != -1;
		}

		#endregion Public Methods
	}
}
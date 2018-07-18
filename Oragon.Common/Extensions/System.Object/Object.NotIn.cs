// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>487370D2-5F68-4462-8EA9-4B194CB442C9</id>
		/// <summary>
		///     A T extension method to determines whether the object is not equal to any of the provided values.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The object to be compared.</param>
		/// <param name="values">The value list to compare with the object.</param>
		/// <returns>true if the values list doesn't contains the object, else false.</returns>
		/// <example>
		///     <code>
		///         var item = 1;
		///
		///         if(item.NotIn(1, 2, 3))
		///         {
		///             // ...Code...
		///         }
		///     </code>
		/// </example>
		public static bool NotIn<T>(this T @this, params T[] values)
		{
			return Array.IndexOf(values, @this) == -1;
		}

		/// <id>1E2FC67A-1254-4293-83DC-DA838971492C</id>
		/// <summary>
		///     A T extension method to determines whether the object is not equal to any of the provided values.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The object to be compared.</param>
		/// <param name="values">The value list to compare with the object.</param>
		/// <returns>true if the values list doesn't contains the object, else false.</returns>
		/// <example>
		///     <code>
		///         var list = new List&lt;int&gt;() { 1, 2, 3 };
		///         var item = 1;
		///
		///         if(item.NotIn(list))
		///         {
		///             // ...Code...
		///         }
		///     </code>
		/// </example>
		public static bool NotIn<T>(this T @this, List<T> values)
		{
			return values.IndexOf(@this) == -1;
		}

		#endregion Public Methods
	}
}
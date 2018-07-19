// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>1E68FC76-A3C5-4E0D-976F-01C0987A2853</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that adds only if the value satisfies the predicate.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="predicate">The predicate.</param>
		/// <param name="value">The value.</param>
		public static void AddIf<T>(this ICollection<T> @this, Func<T, bool> predicate, T value)
		{
			if (predicate(value))
			{
				@this.Add(value);
			}
		}

		#endregion Public Methods
	}
}
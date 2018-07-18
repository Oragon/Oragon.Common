// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>2709E4AA-6C22-4A4A-A24B-B056E21AF3FD</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that queries if the collection is null or is empty.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if null or empty&lt; t&gt;, false if not.</returns>
		public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
		{
			return @this == null || @this.Count == 0;
		}

		#endregion Public Methods
	}
}
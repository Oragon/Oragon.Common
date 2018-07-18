// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>10C069F2-BAC4-4E79-A06D-5917D52E1A11</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that query if the collection is empty
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if empty&lt; t&gt;, false if not.</returns>
		public static bool IsEmpty<T>(this ICollection<T> @this)
		{
			return @this.Count == 0;
		}

		#endregion Public Methods
	}
}
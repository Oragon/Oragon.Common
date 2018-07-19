// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>F669FCDB-0DE9-4E32-9F21-F81ECEE546B3</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that queries if the collection is not (null null is empty).
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if the collection is not (null or empty), false if not.</returns>
		public static bool IsNotNullAndIsNotEmpty<T>(this ICollection<T> @this)
		{
			return @this != null && @this.Count > 0;
		}

		#endregion Public Methods
	}
}
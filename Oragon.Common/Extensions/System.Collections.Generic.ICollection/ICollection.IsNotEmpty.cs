// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>B94EF527-52D6-4281-93DA-EC2A35C98C5B</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that query if the collection is not empty.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if not empty&lt; t&gt;, false if not.</returns>
		public static bool IsNotEmpty<T>(this ICollection<T> @this)
		{
			return @this.Count != 0;
		}

		#endregion Public Methods
	}
}
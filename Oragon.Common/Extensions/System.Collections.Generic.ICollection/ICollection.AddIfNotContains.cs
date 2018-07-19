// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>2A5B3D49-6F76-40B9-B3DC-85E6180E470B</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that add value if the ICollection doesn't contains it already.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="value">The value.</param>
		public static void AddIfNotContains<T>(this ICollection<T> @this, T value)
		{
			if (!@this.Contains(value))
			{
				@this.Add(value);
			}
		}

		#endregion Public Methods
	}
}
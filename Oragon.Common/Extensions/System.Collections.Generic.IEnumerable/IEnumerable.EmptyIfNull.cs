// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Linq;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>DF9E904B-35CA-4507-A7B3-CA4DC88A7B86</id>
		/// <summary>
		///     If the IEnumerable is null than return an empty IEnumerable.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The IEnumerable when not null, otherwise an empty IEnumerable.</returns>
		public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> @this)
		{
			return @this ?? Enumerable.Empty<T>();
		}

		#endregion Public Methods
	}
}
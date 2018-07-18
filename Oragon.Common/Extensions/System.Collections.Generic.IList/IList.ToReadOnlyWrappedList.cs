// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <summary>
		///     Creates a <see cref="IReadOnlyCollection{T}" /> wrapper collection around <paramref name="list" />.
		/// </summary>
		/// <typeparam name="T">The type parameter of the items in the list.</typeparam>
		/// <param name="list">A list object.</param>
		public static IReadOnlyList<T> ToReadOnlyWrappedList<T>(this IList<T> list)
		{
			list.Should().NotBeNull("collection must not be null");
			return new ListReadOnlyWrapper<T>(list);
		}

		#endregion Public Methods
	}
}
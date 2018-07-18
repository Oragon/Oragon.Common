// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using FluentAssertions;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>ED3ED365-C03A-49A5-9C3F-FF55C3716CC0</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that adds a range of values that's not already in the ICollection
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		public static void AddRangeIfNotContains<T>(this ICollection<T> @this, params T[] values)
		{
			@this.Should().NotBeNull();
			values.Should().NotBeNull();
			foreach (T value in values)
			{
				if (!@this.Contains(value))
				{
					@this.Add(value);
				}
			}
		}

		/// <id>3AA11884-4721-43E7-81F8-5FFB8334AA18</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that adds a range of values that's not already in the ICollection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		public static void AddRangeIfNotContains<T>(this ICollection<T> @this, IEnumerable<T> values)
		{
			@this.Should().NotBeNull();
			values.Should().NotBeNull();
			foreach (T value in values)
			{
				if (!@this.Contains(value))
				{
					@this.Add(value);
				}
			}
		}

		#endregion Public Methods
	}
}
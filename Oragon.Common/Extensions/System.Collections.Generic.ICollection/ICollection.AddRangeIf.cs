// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using FluentAssertions;
using System;
using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>DC6B42E9-C0F7-47FE-819D-CF47862B7E72</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that adds a collection of objects to the end of this collection only for value who satisfies
		///     the predicate.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="predicate">The predicate.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2")]
		public static void AddRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, params T[] values)
		{
			@this.Should().NotBeNull();
			predicate.Should().NotBeNull();
			values.Should().NotBeNull();
			foreach (T value in values)
			{
				if (predicate(value))
				{
					@this.Add(value);
				}
			}
		}

		/// <id>6208839E-FA33-451C-A517-FB5BE3295DC1</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that adds a collection of objects to the end of this collection only for value who satisfies
		///     the predicate.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="predicate">The predicate.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2")]
		public static void AddRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, IEnumerable<T> values)
		{
			@this.Should().NotBeNull();
			predicate.Should().NotBeNull();
			values.Should().NotBeNull();
			foreach (T value in values)
			{
				if (predicate(value))
				{
					@this.Add(value);
				}
			}
		}

		#endregion Public Methods
	}
}
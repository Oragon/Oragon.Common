// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using FluentAssertions;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>CABCC442-7134-4FCA-AA4E-1640FAD01D42</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that adds a range to 'values'.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
		public static void AddRange<T>(this ICollection<T> @this, params T[] values)
		{
			@this.Should().NotBeNull();
			values.Should().NotBeNull();
			foreach (T value in values)
			{
				@this.Add(value);
			}
		}

		/// <id>12B9A95F-E047-44E6-B616-8B0AFC14E63E</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that adds a range to 'values'.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
		public static void AddRange<T>(this ICollection<T> @this, IEnumerable<T> values)
		{
			@this.Should().NotBeNull();
			values.Should().NotBeNull();
			foreach (T value in values)
			{
				@this.Add(value);
			}
		}

		#endregion Public Methods
	}
}
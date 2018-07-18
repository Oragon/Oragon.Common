// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Determines the index of a specific item in <paramref name="readOnlyList"/>.
		///</summary>
		///<typeparam name="T">The type parameter of the items in the read-only list.</typeparam>
		///<param name="readOnlyList"></param>
		///<param name="value">The object to locate in <paramref name="readOnlyList"/>.</param>
		///<returns>The index of value if found in the list; otherwise, -1.</returns>
		///<remarks>This method uses the EqualityComparer$lt;T&gt;.Default.Equals() method on <paramref name="value"/> to determine whether item exists</remarks>
		public static int IndexOf<T>(this IReadOnlyList<T> readOnlyList, T value)
		{
			readOnlyList.Should().NotBeNull("readOnlyList must not be null");
			var count = readOnlyList.Count;
			var equalityComparer = EqualityComparer<T>.Default;
			for (var i = 0; i < count; i++)
			{
				var current = readOnlyList[i];
				if (equalityComparer.Equals(current, value)) { return i; }
			}
			return -1;
		}

		#endregion Public Methods
	}
}
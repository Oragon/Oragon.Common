// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Produces the set <paramref name="seq"/> excluding <paramref name="elementExcluded"/>. The equality test relies on the <i>Equals()</i> method.
		///</summary>
		///<typeparam name="T">The element type.</typeparam>
		///<param name="seq">A sequence of elements.</param>
		///<param name="elementExcluded">The element excluded.</param>
		///<returns>A sequence that contains the set difference of the elements of <paramref name="seq"/> minus <paramref name="elementExcluded"/>.</returns>
		///<remarks>This extension method has a <i>constant</i> time complexity.</remarks>
		public static IEnumerable<T> Except<T>(this IEnumerable<T> seq, T elementExcluded)
		{
			seq.Should().NotBeNull("seq must not be null");			
			foreach (var element in seq)
			{
				if (elementExcluded.Equals(element)) { continue; }
				yield return element;
			}
		}

		///<summary>
		///Produces the set difference of this <paramref name="seq"/> and <paramref name="hashset"/>. This method is an optimized version of <i>Enumerable.Except&lt;T&gt;</i>.
		///</summary>
		///<typeparam name="T">The element type of the elements of the hashset and the sequence.</typeparam>
		///<param name="seq">A sequence of elements whose elements that are not also in <paramref name="hashset"/> will be returned.</param>
		///<param name="hashset">An hashset of elements whose elements that also occur in <paramref name="seq"/> will cause those elements to be removed from the returned sequence.</param>
		///<returns>A sequence that contains the set difference of the elements of <paramref name="seq"/> and <paramref name="hashset"/>.</returns>
		///<remarks>This extension method has a <i>O(<paramref name="seq"/>.Count)</i> time complexity.</remarks>
		public static IEnumerable<T> Except<T>(this IEnumerable<T> seq, HashSet<T> hashset) where T : class
		{
			seq.Should().NotBeNull("seq must not be null");
			hashset.Should().NotBeNull("hashset must not be null");
			foreach (var t in seq)
			{
				if (hashset.Contains(t)) { continue; }
				yield return t;
			}
		}

		#endregion Public Methods
	}
}
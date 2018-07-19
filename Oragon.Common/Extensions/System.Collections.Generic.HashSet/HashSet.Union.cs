// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Produces the set of elements, union of this <paramref name="hashSet"/> and <paramref name="seq"/>. This method is an optimized version of <i>Enumerable.Union&lt;T&gt;</i>.
		///</summary>
		///<typeparam name="T">The code element type of the elements of the hashset and the sequence.</typeparam>
		///<param name="hashSet">An hashset of elements whose distinct elements form the first set for the union.</param>
		///<param name="seq">A sequence of elements whose distinct elements form the second set for the union.</param>
		///<returns>A sequence that contains the elements that form the set union of the hashset and the sequence, excluding duplicates.</returns>
		///<remarks>This extension method has a <i>O(<paramref name="seq"/>.Count)</i> time complexity.</remarks>
		public static IEnumerable<T> Union<T>(this HashSet<T> hashSet, IEnumerable<T> seq)
		{
			hashSet.Should().NotBeNull("hashset must not be null");
			seq.Should().NotBeNull("seq must not be null");
			var returnValue = UnionIterator(hashSet, seq);
			return returnValue;
		}

		///<summary>
		///Produces the set of elements, union of this <paramref name="thisHashSet"/> and <paramref name="otherHashSet"/>. This method is an optimized version of <i>Enumerable.Union&lt;T&gt;</i>.
		///</summary>
		///<typeparam name="T">The code element type of the elements of the hashset and the sequence.</typeparam>
		///<param name="thisHashSet">A sequence of elements whose distinct elements form the first set for the union.</param>
		///<param name="otherHashSet">An hashset of elements whose distinct elements form the second set for the union.</param>
		///<returns>A sequence that contains the elements that form the set union of both hashsets, excluding duplicates.</returns>
		///<remarks>This extension method has a <i>O(<paramref name="otherHashSet"/>.Count)</i> time complexity.</remarks>
		public static IEnumerable<T> Union<T>(this HashSet<T> thisHashSet, HashSet<T> otherHashSet)
		{
			thisHashSet.Should().NotBeNull("hashset must not be null");
			otherHashSet.Should().NotBeNull("otherHashset must not be null");
			var returnValue = UnionIterator(thisHashSet, otherHashSet);
			return returnValue;
		}

		#endregion Public Methods
	}
}
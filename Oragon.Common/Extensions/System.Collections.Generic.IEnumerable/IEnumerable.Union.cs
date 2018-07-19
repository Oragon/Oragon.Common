// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Produces the set of elements, union of this <paramref name="seq"/> and <paramref name="hashset"/>. This method is an optimized version of <i>Enumerable.Union&lt;T&gt;</i>.
		///</summary>
		///<typeparam name="T">The code element type of the elements of the hashset and the sequence.</typeparam>
		///<param name="hashset">An hashset of elements whose distinct elements form the first set for the union.</param>
		///<param name="seq">A sequence of elements whose distinct elements form the second set for the union.</param>
		///<returns>A sequence that contains the elements that form the set union of the sequence and the hashset, excluding duplicates.</returns>
		///<remarks>This extension method has a <i>O(<paramref name="seq"/>.Count)</i> time complexity.</remarks>
		public static IEnumerable<T> Union<T>(this IEnumerable<T> seq, HashSet<T> hashset)
		{
			seq.Should().NotBeNull("seq must not be null");
			hashset.Should().NotBeNull("hashset must not be null");			
			return UnionIterator(hashset, seq);
		}

		#endregion Public Methods
	}
}
using System.Collections.Generic;
using FluentAssertions;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Produces the set of elements, intersection of this <paramref name="hashSet"/> and <paramref name="seq"/>. This method is an optimized version of <i>Enumerable.Intersect&lt;T&gt;</i>.
		///</summary>
		///<typeparam name="T">The code element type of the elements of the hashset and the sequence.</typeparam>
		///<param name="hashSet">An hashset of elements whose distinct elements that also appear in <paramref name="seq"/> will be returned.</param>
		///<param name="seq">A sequence of elements whose distinct elements that also appear in <paramref name="hashSet"/> will be returned.</param>
		///<returns>A sequence that contains the elements that form the set intersection of the hashset and the sequence.</returns>
		///<remarks>This extension method has a <i>O(<paramref name="seq"/>.Count)</i> time complexity.</remarks>
		public static IEnumerable<T> Intersect<T>(this HashSet<T> hashSet, IEnumerable<T> seq)
		{
			hashSet.Should().NotBeNull("hashset must not be null");
			seq.Should().NotBeNull("seq must not be null");
			return IntersectIterator(hashSet, seq);
		}

		///<summary>
		///Produces the set of elements, intersection of this <paramref name="hashSet"/> and <paramref name="otherHashset"/>. This method is an optimized version of <i>Enumerable.Intersect&lt;T&gt;</i>.
		///</summary>
		///<typeparam name="T">The code element type of the elements of the hashset and the sequence.</typeparam>
		///<param name="hashSet">An hashset of elements whose distinct elements that also appear in <paramref name="otherHashset"/> will be returned.</param>
		///<param name="otherHashset">An hashset of elements whose distinct elements that also appear in <paramref name="hashSet"/> will be returned.</param>
		///<returns>A sequence that contains the elements that form the set intersection of both hashsets.</returns>
		///<remarks>This extension method has a <i>O(<paramref name="otherHashset"/>.Count)</i> time complexity.</remarks>
		public static IEnumerable<T> Intersect<T>(this HashSet<T> hashSet, HashSet<T> otherHashset)
		{
			hashSet.Should().NotBeNull("hashset must not be null");
			otherHashset.Should().NotBeNull("otherHashset must not be null");
			return IntersectIterator(hashSet, otherHashset);
		}

		#endregion Public Methods

		#region Private Methods

		private static IEnumerable<T> IntersectIterator<T>(HashSet<T> hashset, IEnumerable<T> seq)
		{
			foreach (var t in seq)
			{
				if (!hashset.Contains(t)) { continue; }
				yield return t;
			}
		}

		#endregion Private Methods
	}
}
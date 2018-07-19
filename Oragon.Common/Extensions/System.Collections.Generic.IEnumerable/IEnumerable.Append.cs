// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Append <paramref name="element"/> at the end of <paramref name="seq"/>.
		///</summary>
		///<typeparam name="T">The element type.</typeparam>
		///<param name="seq">A sequence of elements.</param>
		///<param name="element">The element to append.</param>
		///<remarks>This extension method has a <i>constant</i> time complexity.</remarks>
		public static IEnumerable<T> Append<T>(this IEnumerable<T> seq, T element)
		{
			seq.Should().NotBeNull("seq must not be null");
			//Contract.Requires(element != null, "element must not be null");
			foreach (var elem in seq)
			{
				yield return elem;
			}
			yield return element;
		}

		///<summary>
		///Append <paramref name="element1"/> and <paramref name="element1"/> at the end of <paramref name="seq"/>.
		///</summary>
		///<typeparam name="T">The element type.</typeparam>
		///<param name="seq">A sequence of elements.</param>
		///<param name="element1">The element to append first.</param>
		///<param name="element2">The element to append after <paramref name="element1"/>.</param>
		///<remarks>This extension method has a <i>constant</i> time complexity.</remarks>
		public static IEnumerable<T> Append<T>(this IEnumerable<T> seq, T element1, T element2)
		{
			seq.Should().NotBeNull("seq must not be null");			
			foreach (var elem in seq)
			{
				yield return elem;
			}
			yield return element1;
			yield return element2;
		}

		///<summary>
		///Append <paramref name="element1"/>, <paramref name="element2"/> and <paramref name="element3"/> at the end of <paramref name="seq"/>.
		///</summary>
		///<remarks>To append more than 3 elements to <paramref name="seq"/>, use the <i>.Concat(new [] { a, b, c, d ... } )</i> syntax.</remarks>
		///<typeparam name="T">The element type.</typeparam>
		///<param name="seq">A sequence of elements.</param>
		///<param name="element1">The element to append first.</param>
		///<param name="element2">The element to append after <paramref name="element1"/>.</param>
		///<param name="element3">The element to append after <paramref name="element2"/>.</param>
		///<remarks>This extension method has a <i>constant</i> time complexity.</remarks>
		public static IEnumerable<T> Append<T>(this IEnumerable<T> seq, T element1, T element2, T element3)
		{
			seq.Should().NotBeNull("seq must not be null");
			foreach (var elem in seq)
			{
				yield return elem;
			}
			yield return element1;
			yield return element2;
			yield return element3;
		}

		///<summary>
		///Append <paramref name="element1"/>, <paramref name="element2"/> and <paramref name="element3"/> at the end of <paramref name="seq"/>.
		///</summary>
		///<remarks>To append more than 3 elements to <paramref name="seq"/>, use the <i>.Concat(new [] { a, b, c, d ... } )</i> syntax.</remarks>
		///<typeparam name="T">The element type.</typeparam>
		///<param name="seq">A sequence of elements.</param>
		///<param name="element1">The element to append first.</param>
		///<param name="element2">The element to append after <paramref name="element1"/>.</param>
		///<param name="element3">The element to append after <paramref name="element2"/>.</param>
		///<param name="element4">The element to append after <paramref name="element3"/>.</param>
		///<remarks>This extension method has a <i>constant</i> time complexity.</remarks>
		public static IEnumerable<T> Append<T>(this IEnumerable<T> seq, T element1, T element2, T element3, T element4)
		{
			seq.Should().NotBeNull("seq must not be null");
			foreach (var elem in seq)
			{
				yield return elem;
			}
			yield return element1;
			yield return element2;
			yield return element3;
			yield return element4;
		}

		///<summary>
		///Append <paramref name="element1"/>, <paramref name="element2"/> and <paramref name="element3"/> at the end of <paramref name="seq"/>.
		///</summary>
		///<remarks>To append more than 3 elements to <paramref name="seq"/>, use the <i>.Concat(new [] { a, b, c, d ... } )</i> syntax.</remarks>
		///<typeparam name="T">The element type.</typeparam>
		///<param name="seq">A sequence of elements.</param>
		///<param name="element1">The element to append first.</param>
		///<param name="element2">The element to append after <paramref name="element1"/>.</param>
		///<param name="element3">The element to append after <paramref name="element2"/>.</param>
		///<param name="element4">The element to append after <paramref name="element3"/>.</param>
		///<param name="element5">The element to append after <paramref name="element4"/>.</param>
		///<remarks>This extension method has a <i>constant</i> time complexity.</remarks>
		public static IEnumerable<T> Append<T>(this IEnumerable<T> seq, T element1, T element2, T element3, T element4, T element5)
		{
			seq.Should().NotBeNull("seq must not be null");
			foreach (var elem in seq)
			{
				yield return elem;
			}
			yield return element1;
			yield return element2;
			yield return element3;
			yield return element4;
			yield return element5;
		}

		#endregion Public Methods
	}
}
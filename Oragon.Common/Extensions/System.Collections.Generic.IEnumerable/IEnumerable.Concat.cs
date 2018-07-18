// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;
using System.Linq;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Gets an enumerable object that contains the elements of <paramref name="elements"/> and then <paramref name="element"/>, in this order.
		///</summary>
		///<typeparam name="TElement">The type of <paramref name="element"/>.</typeparam>
		///<param name="elements">The first elements in the returned enumerable.</param>
		///<param name="element">The last element in the returned enumerable.</param>
		public static IEnumerable<TElement> Concat<TElement>(this IEnumerable<TElement> elements, TElement element)
		{
			return elements.Concat(new[] { element });
		}

		#endregion Public Methods
	}
}
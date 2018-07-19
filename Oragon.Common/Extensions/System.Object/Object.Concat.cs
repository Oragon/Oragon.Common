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
		///Gets an enumerable object that contains first <paramref name="element"/> and then elements of <paramref name="elements"/>, in this order.
		///</summary>
		///<typeparam name="TElement">The type of <paramref name="element"/>.</typeparam>
		///<param name="element">The first element in the returned enumerable.</param>
		///<param name="elements">The last elements in the returned enumerable.</param>
		public static IEnumerable<TElement> Concat<TElement>(this TElement element, IEnumerable<TElement> elements)
		{
			return new[] { element }.Concat(elements);
		}

		#endregion Public Methods
	}
}
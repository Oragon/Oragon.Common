// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Gets an enumerable object that contains only the single element <paramref name="element"/>.
		///</summary>
		///<typeparam name="TElement">The type of <paramref name="element"/>.</typeparam>
		///<param name="element">The single element in the returned enumerable.</param>
		public static IEnumerable<TElement> ToEnumerable<TElement>(this TElement element)
		{
			// This implementation is faster in all case than: yield return elem;
			return new[] { element };
		}

		#endregion Public Methods
	}
}
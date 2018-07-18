// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using FluentAssertions;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>
		///Creates an hashset from a <i>IEnumerable&lt;T&gt;</i>.
		///</summary>
		///<typeparam name="T">The type of the elements of <paramref name="seq"/>.</typeparam>
		///<param name="seq">An <i>IEnumerable&lt;T&gt;</i> to create an hashset from.</param>
		///<returns>An hashset that contains the elements from the input sequence.</returns>
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> seq)
		{
			seq.Should().NotBeNull("seq must not be null");
			return new HashSet<T>(seq);
		}

		#endregion Public Methods
	}
}
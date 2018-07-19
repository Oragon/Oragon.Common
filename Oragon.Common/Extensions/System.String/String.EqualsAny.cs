// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using FluentAssertions;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		///<summary>Gets a value indicating whether this string is equal <i>case sensitive</i> to any of the strings specified.</summary>
		///<param name="thisString">This string.</param>
		///<param name="str0">One of the possible value for <paramref name="thisString"/>.</param>
		///<param name="str1">One of the possible value for <paramref name="thisString"/>.</param>
		public static bool EqualsAny(this string thisString, params string[] args)
		{
			thisString.Should().NotBeNull("str must not be null");
			return args.Any(currentArg => currentArg == thisString);
		}

		#endregion Public Methods
	}
}
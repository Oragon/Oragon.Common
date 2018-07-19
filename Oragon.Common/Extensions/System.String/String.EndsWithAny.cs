// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using FluentAssertions;
using System.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <summary>
		///     Gets a value indicating whether this string is equal <i>case sensitive</i> to any of the strings specified.
		/// </summary>
		/// <param name="thisString"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public static bool EndsWithAny(this string thisString, params string[] args)
		{
			thisString.Should().NotBeNull("str must not be null");
			args.Should().NotBeNull("args must not be null");
			return args.Any(currentArg => thisString.EndsWith(currentArg));
		}

		#endregion Public Methods
	}
}
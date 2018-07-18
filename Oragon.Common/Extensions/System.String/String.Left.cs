// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>37D8994E-550E-4E9C-B9D0-43B21FB464CF</id>
		/// <summary>
		///     A string extension method that return the left part of the string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="length">The length.</param>
		/// <returns>The left part</returns>
		public static string Left(this string @this, int length)
		{
			return @this.Substring(0, length);
		}

		#endregion Public Methods
	}
}
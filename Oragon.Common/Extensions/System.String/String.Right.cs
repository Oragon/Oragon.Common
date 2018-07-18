// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>E1CE7FF3-A6CC-406A-B07A-0F537AF7C3B0</id>
		/// <summary>
		///     A string extension method that return the right part of the string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="length">The length.</param>
		/// <returns>The right part</returns>
		public static string Right(this string @this, int length)
		{
			return @this.Substring(@this.Length - length);
		}

		#endregion Public Methods
	}
}
// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>7EF2717D-A5AA-45F5-AD50-47AB8AD046A7</id>
		/// <summary>
		///     A string extension method that reverses the given string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The string reversed</returns>
		public static string Reverse(this string @this)
		{
			if (@this.Length <= 1)
			{
				return @this;
			}

			char[] chars = @this.ToCharArray();
			Array.Reverse(chars);
			return new string(chars);
		}

		#endregion Public Methods
	}
}
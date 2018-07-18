// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>0BDBC3FE-C9D1-45BA-9887-D4089456FE2D</id>
		/// <summary>
		///     A string extension method that converts the @this to an enum.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a T.</returns>
		public static T ToEnum<T>(this string @this)
		{
			Type enumType = typeof(T);
			return (T)Enum.Parse(enumType, @this);
		}

		#endregion Public Methods
	}
}
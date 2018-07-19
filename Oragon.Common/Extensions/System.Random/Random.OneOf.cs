// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>95E58958-F3FE-4F2E-ABE4-786788FF5DB8</id>
		/// <summary>
		///     A Random extension method that return at random one of the value.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing arguments.</param>
		/// <returns>One of the specified value.</returns>
		public static T OneOf<T>(this Random @this, params T[] values)
		{
			return values[@this.Next(values.Length)];
		}

		/// <id>904DF1AC-D0E8-4850-B96F-146E435E5FF7</id>
		/// <summary>
		///     A Random extension method that return at random one of the value.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing arguments.</param>
		/// <returns>One of the specified value.</returns>
		public static T OneOf<T>(this Random @this, List<T> values)
		{
			return values[@this.Next(values.Count)];
		}

		#endregion Public Methods
	}
}
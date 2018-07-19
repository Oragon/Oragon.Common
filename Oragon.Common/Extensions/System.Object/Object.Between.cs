// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>6F239711-2522-49D9-8C6D-32B4EFF40093</id>
		/// <summary>
		///     A T extension method that check if the value is between the minValue and maxValue.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="minValue">The minimum value.</param>
		/// <param name="maxValue">The maximum value.</param>
		/// <returns>true if the value is between the minValue and maxValue, otherwise false.</returns>
		public static bool Between<T>(this T @this, T minValue, T maxValue) where T : IComparable<T>
		{
			return minValue.CompareTo(@this) == -1 && @this.CompareTo(maxValue) == -1;
		}

		#endregion Public Methods
	}
}
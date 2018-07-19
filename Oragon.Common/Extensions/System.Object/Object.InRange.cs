// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>5AD22F51-335B-4544-8528-D7A87A5CBFF0</id>
		/// <summary>
		///     A T extension method that check if the value is between inclusively the minValue and maxValue.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="minValue">The minimum value.</param>
		/// <param name="maxValue">The maximum value.</param>
		/// <returns>true if the value is between inclusively the minValue and maxValue, otherwise false.</returns>
		public static bool InRange<T>(this T @this, T minValue, T maxValue) where T : IComparable<T>
		{
			return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
		}

		#endregion Public Methods
	}
}
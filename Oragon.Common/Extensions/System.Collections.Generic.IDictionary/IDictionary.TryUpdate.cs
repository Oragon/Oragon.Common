// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>B5F64F21-3ADC-4955-B5C8-DE53D06F81F8</id>
		/// <summary>
		///     Attempts to update the specified key and value to the IDictionary&lt;TKey, TValue&gt;.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key replaced.</param>
		/// <param name="value">The value that replaces the value of the element that has the specified key.</param>
		/// <returns>true if the value has been replaced in the IDictionary&lt;TKey, TValue&gt; otherwise, false.</returns>
		public static bool TryUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
		{
			if (@this.ContainsKey(key))
			{
				@this[key] = value;
				return true;
			}

			return false;
		}

		/// <id>4B36C1E9-27A6-4A7F-9A1D-F1339A69B680</id>
		/// <summary>
		///     Compares the existing value for the specified key with a specified value, and if they are equal, updates the key with a third value.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key whose value is compared with comparisonValue and possibly replaced.</param>
		/// <param name="value">The value that replaces the value of the element that has the specified key if the comparison results in equality.</param>
		/// <param name="comparisonValue">The value that is compared to the value of the element that has the specified key.</param>
		/// <returns>true if the value with key was equal to comparisonValue and was replaced with newValue; otherwise, false.</returns>
		public static bool TryUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value,
			TValue comparisonValue)
		{
			if (@this.ContainsKey(key) && @this[key].Equals(comparisonValue))
			{
				@this[key] = value;
				return true;
			}

			return false;
		}

		#endregion Public Methods
	}
}
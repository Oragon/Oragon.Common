// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>90D31FDC-E67B-4207-B406-F323F4ECA101</id>
		/// <summary>
		///     Attempts to get the value associated with the specified key from the IDictionary&lt;TKey, TValue&gt;.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">
		///     [out] When this method returns, contains the object from the IDictionary&lt;TKey, TValue&gt; that has the specified key, or the
		///     default value of , if the operation failed.
		/// </param>
		/// <returns>true if the key was found in the IDictionary&lt;TKey, TValue&gt;, otherwise, false.</returns>
		public static bool TryGetValue<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, out TValue value)
		{
			if (@this.ContainsKey(key))
			{
				value = @this[key];
				return true;
			}

			value = default(TValue);
			return false;
		}

		#endregion Public Methods
	}
}
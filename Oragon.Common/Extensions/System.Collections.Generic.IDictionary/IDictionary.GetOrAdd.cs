// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>EFC83FA9-66A6-491E-81D2-4584F8B9B0DB</id>
		/// <summary>
		///     Adds a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does not already exist.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value to be added, if the key does not already exist.</param>
		/// <returns>
		///     The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value if
		///     the key was not in the dictionary.
		/// </returns>
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
		{
			if (!@this.ContainsKey(key))
			{
				@this.Add(new KeyValuePair<TKey, TValue>(key, value));
			}

			return @this[key];
		}

		/// <id>D184638F-80A2-4C6D-B7C4-C3EBAC8EF701</id>
		/// <summary>
		///     Adds a key/value pair to the IDictionary&lt;TKey, TValue&gt; by using the specified function, if the key does not already exist.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="valueFactory">TThe function used to generate a value for the key.</param>
		/// <returns>
		///     The value for the key. This will be either the existing value for the key if the key is already in the dictionary, or the new value
		///     for the key as returned by valueFactory if the key was not in the dictionary.
		/// </returns>
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key,
			Func<TKey, TValue> valueFactory)
		{
			if (!@this.ContainsKey(key))
			{
				@this.Add(new KeyValuePair<TKey, TValue>(key, valueFactory(key)));
			}

			return @this[key];
		}

		#endregion Public Methods
	}
}
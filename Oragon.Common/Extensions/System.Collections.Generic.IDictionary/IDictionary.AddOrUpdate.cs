// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>1F9109F9-1D9F-4D67-B03F-F179FB6ECF44</id>
		/// <summary>
		///     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does not already exist, or to
		///     update a key/value pair in the IDictionary&lt;TKey, TValue&gt;&gt; if the key already exists.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key to be added or whose value should be updated.</param>
		/// <param name="value">The value to be added or updated.</param>
		/// <returns>The new value for the key.</returns>
		public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
		{
			if (!@this.ContainsKey(key))
			{
				@this.Add(new KeyValuePair<TKey, TValue>(key, value));
			}
			else
			{
				@this[key] = value;
			}

			return @this[key];
		}

		/// <id>6466eba0-1951-4758-b848-fdcfb1a8b157</id>
		/// <summary>
		///     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does not already exist, or to
		///     update a key/value pair in the IDictionary&lt;TKey, TValue&gt;&gt; if the key already exists.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key to be added or whose value should be updated.</param>
		/// <param name="addValue">The value to be added for an absent key.</param>
		/// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value.</param>
		/// <returns>
		///     The new value for the key. This will be either be addValue (if the key was absent) or the result of updateValueFactory (if the key was present).
		/// </returns>
		public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue addValue,
			Func<TKey, TValue, TValue> updateValueFactory)
		{
			if (!@this.ContainsKey(key))
			{
				@this.Add(new KeyValuePair<TKey, TValue>(key, addValue));
			}
			else
			{
				@this[key] = updateValueFactory(key, @this[key]);
			}

			return @this[key];
		}

		/// <id>1eeb3843-be83-46e2-9505-0f9ad35c3839</id>
		/// <summary>
		///     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does not already exist, or to
		///     update a key/value pair in the IDictionary&lt;TKey, TValue&gt;&gt; if the key already exists.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key to be added or whose value should be updated.</param>
		/// <param name="addValueFactory">The function used to generate a value for an absent key.</param>
		/// <param name="updateValueFactory">The function used to generate a new value for an existing key based on the key's existing value.</param>
		/// <returns>
		///     The new value for the key. This will be either be the result of addValueFactory (if the key was absent) or the result of
		///     updateValueFactory (if the key was present).
		/// </returns>
		public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key,
			Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
		{
			if (!@this.ContainsKey(key))
			{
				@this.Add(new KeyValuePair<TKey, TValue>(key, addValueFactory(key)));
			}
			else
			{
				@this[key] = updateValueFactory(key, @this[key]);
			}

			return @this[key];
		}

		#endregion Public Methods
	}
}
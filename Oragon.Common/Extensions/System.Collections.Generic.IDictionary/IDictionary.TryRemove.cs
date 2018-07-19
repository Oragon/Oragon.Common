// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>61BC3034-0065-41CA-93F0-90675EBCDBCE</id>
		/// <summary>
		///     Attempts to remove and return the value that has the specified key from the IDictionary&lt;TKey, TValue&gt;.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key of the element to remove and return.</param>
		/// <param name="value">
		///     [out] When this method returns, contains the object removed from the IDictionary&lt;TKey, TValue&gt;, or the default value of the
		///     TValue type if key does not exist.
		/// </param>
		/// <returns>true if the object was removed successfully; otherwise, false.</returns>
		public static bool TryRemove<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, out TValue value)
		{
			if (@this.ContainsKey(key))
			{
				value = @this[key];
				@this.Remove(key);
				return true;
			}

			value = default(TValue);
			return false;
		}

		/// <id>598EBF44-99CF-4680-BB0D-C63BB2A6CA6E</id>
		/// <summary>
		///     Attempts to remove and that has the specified key from the IDictionary&lt;TKey, TValue&gt;.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key of the element to remove.</param>
		/// <returns>true if the object was removed successfully; otherwise, false.</returns>
		public static bool TryRemove<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key)
		{
			if (@this.ContainsKey(key))
			{
				@this.Remove(key);
				return true;
			}

			return false;
		}

		#endregion Public Methods
	}
}
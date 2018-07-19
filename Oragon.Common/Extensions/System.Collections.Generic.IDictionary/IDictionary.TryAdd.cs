// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>C987643D-016C-40FB-9C51-FFCCE3D0E003</id>
		/// <summary>
		///     Attempts to add the specified key and value to the IDictionary&lt;TKey, TValue&gt;.
		/// </summary>
		/// <typeparam name="TKey">Type of the key.</typeparam>
		/// <typeparam name="TValue">Type of the value.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key of the element to add.</param>
		/// <param name="value">The value of the element to add. The value can be null for reference types.</param>
		/// <returns>true if the key/value pair was added to the IDictionary&lt;TKey, TValue&gt; successfully; false if the key already exists.</returns>
		public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
		{
			if (!@this.ContainsKey(key))
			{
				@this.Add(key, value);
				return true;
			}

			return false;
		}

		#endregion Public Methods
	}
}
// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Collections.Generic;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>10D077CC-724F-4B46-949B-D5A3430567BD</id>
		/// <summary>
		///     An ICollection&lt;T&gt; extension method that try remove the value.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="value">The value.</param>
		/// <returns>true if it succeeds, false if it fails.</returns>
		public static bool TryRemove<T>(this ICollection<T> @this, T value)
		{
			try
			{
				if (@this.Contains(value))
				{
					@this.Remove(value);
					return true;
				}
			}
			catch(Exception)
			{
				return false;
			}
			return false;
		}

		#endregion Public Methods
	}
}
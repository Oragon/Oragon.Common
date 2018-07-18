// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>0A7CF05C-57BC-40DA-A118-CCB7B725A876</id>
		/// <summary>
		///     A byte[] extension method that converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded
		///     with base-64 digits.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The string representation of the array of 8-bit unsigned integers that is encoded with base-64 digits.</returns>
		public static string ToBase64String(this byte[] @this)
		{
			return Convert.ToBase64String(@this);
		}

		#endregion Public Methods
	}
}
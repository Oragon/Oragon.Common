// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Text;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>33F17764-49C7-47FB-B68D-FC0BACABE88C</id>
		/// <summary>
		///     A string extension method that converts the @this to a byte array.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a byte[].</returns>
		public static byte[] ToByteArray(this string @this)
		{
			Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
			return encoding.GetBytes(@this);
		}

		#endregion Public Methods
	}
}
// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Security.Cryptography;
using System.Text;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>DC4B1713-41B5-48BB-BE4D-308FECE3DC02</id>
		/// <summary>
		///     A string extension method that encrypts the string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key.</param>
		/// <returns>The encrypted string.</returns>
		public static string EncryptRSA(this string @this, string key)
		{
			var cspp = new CspParameters { KeyContainerName = key };
			var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
			byte[] bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(@this), true);

			return BitConverter.ToString(bytes);
		}

		#endregion Public Methods
	}
}
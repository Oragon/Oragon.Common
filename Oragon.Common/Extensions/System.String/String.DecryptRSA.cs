// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>02D4806A-ADF8-4927-A7C2-CB537346B781</id>
		/// <summary>
		///     A string extension method that decrypt a string.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="key">The key.</param>
		/// <returns>The decrypted string.</returns>
		public static string DecryptRSA(this string @this, string key)
		{
			var cspp = new CspParameters { KeyContainerName = key };
			var rsa = new RSACryptoServiceProvider(cspp) { PersistKeyInCsp = true };
			string[] decryptArray = @this.Split(new[] { "-" }, StringSplitOptions.None);
			byte[] decryptByteArray = Array.ConvertAll(decryptArray, (s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber))));
			byte[] bytes = rsa.Decrypt(decryptByteArray, true);

			return Encoding.UTF8.GetString(bytes);
		}

		#endregion Public Methods
	}
}
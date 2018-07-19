// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Text;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>1F429948-DF8C-420D-94C1-508A53F3E51E</id>
		/// <summary>
		///     A string extension method that encode the string to Base64.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The encoded string to Base64.</returns>
		public static string EncodeBase64(this string @this)
		{
			return Convert.ToBase64String(Activator.CreateInstance<ASCIIEncoding>().GetBytes(@this));
		}

		#endregion Public Methods
	}
}
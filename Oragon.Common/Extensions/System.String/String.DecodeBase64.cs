// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Text;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>A008C7C0-9E85-41EF-9515-02FCDFF3DB8F</id>
		/// <summary>
		///     A string extension method that decode a Base64 String.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The Base64 String decoded.</returns>
		public static string DecodeBase64(this string @this)
		{
			return Encoding.ASCII.GetString(Convert.FromBase64String(@this));
		}

		#endregion Public Methods
	}
}
// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Text;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>98EFF073-5103-4E91-B52F-7273EDA7B560</id>
		/// <summary>
		///     A string extension method that converts the @this to a MemoryStream.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a MemoryStream.</returns>
		public static Stream ToMemoryStream(this string @this)
		{
			Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
			return new MemoryStream(encoding.GetBytes(@this));
		}

		#endregion Public Methods
	}
}
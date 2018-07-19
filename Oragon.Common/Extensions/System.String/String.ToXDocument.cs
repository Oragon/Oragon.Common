// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>54317AC2-378B-4108-B96B-55364F1AE69C</id>
		/// <summary>
		///     A string extension method that converts the @this to a XDocument.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as an XDocument.</returns>
		public static XDocument ToXDocument(this string @this)
		{
			Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
			using (var ms = new MemoryStream(encoding.GetBytes(@this)))
			{
				return XDocument.Load(ms);
			}
		}

		#endregion Public Methods
	}
}
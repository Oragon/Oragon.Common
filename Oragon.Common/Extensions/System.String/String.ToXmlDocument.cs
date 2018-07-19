// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Xml;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>F1A1AC08-F3D2-4936-AB15-05C6E4EF86C0</id>
		/// <summary>
		///     A string extension method that converts the @this to an XmlDocument.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as an XmlDocument.</returns>
		public static XmlDocument ToXmlDocument(this string @this)
		{
			var doc = new XmlDocument();
			doc.LoadXml(@this);
			return doc;
		}

		#endregion Public Methods
	}
}
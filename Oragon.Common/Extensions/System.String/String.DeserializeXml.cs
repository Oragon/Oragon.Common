// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Xml.Serialization;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>CA5382C8-6A5E-4F78-AFE3-FC77C4C06E2A</id>
		/// <summary>
		///     A string extension method that deserialize an Xml as &lt;T&gt;.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The desieralize Xml as &lt;T&gt;</returns>
		public static T DeserializeXml<T>(this string @this)
		{
			var x = new XmlSerializer(typeof(T));
			var r = new StringReader(@this);

			return (T)x.Deserialize(r);
		}

		#endregion Public Methods
	}
}
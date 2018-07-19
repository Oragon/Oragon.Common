// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Xml.Serialization;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>78C0CF79-8510-47A2-803D-232626C985CA</id>
		/// <summary>
		///     An object extension method that serialize a string to XML.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The string representation of the Xml Serialization.</returns>
		public static string SerializeXml(this object @this)
		{
			var xmlSerializer = new XmlSerializer(@this.GetType());

			using (var stringWriter = new StringWriter())
			{
				xmlSerializer.Serialize(stringWriter, @this);
				using (var streamReader = new StringReader(stringWriter.GetStringBuilder().ToString()))
				{
					return streamReader.ReadToEnd();
				}
			}
		}

		#endregion Public Methods
	}
}
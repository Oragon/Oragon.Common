// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>7D2C5D9B-D35A-45F3-84EF-4CF9854773F2</id>
		/// <summary>
		///     An object extension method that serialize an object to binary.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The string representation of the binary serialization.</returns>
		public static string SerializeBinary(this object @this)
		{
			var binaryWrite = new BinaryFormatter();

			using (var memoryStream = new MemoryStream())
			{
				binaryWrite.Serialize(memoryStream, @this);
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		#endregion Public Methods
	}
}
// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>5B08F5E4-76DA-496A-85F2-3933AAF0AF97</id>
		/// <summary>
		///     A string extension method that deserialize a string binary as &lt;T&gt;.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The desrialize binary as &lt;T&gt;</returns>
		public static T DeserializeBinary<T>(this string @this)
		{
			using (var stream = new MemoryStream(Convert.FromBase64String(@this)))
			{
				var binaryRead = new BinaryFormatter();
				return (T)binaryRead.Deserialize(stream);
			}
		}

		#endregion Public Methods
	}
}
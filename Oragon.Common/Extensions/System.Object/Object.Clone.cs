// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>5C2EF3D3-2457-4861-88CB-A825A0F722F6</id>
		/// <summary>
		///     A T extension method that makes a deep copy of this object.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <returns>the copied object.</returns>
		public static T Clone<T>(this T @this)
		{
			IFormatter formatter = new BinaryFormatter();
			using (var stream = new MemoryStream())
			{
				formatter.Serialize(stream, @this);
				stream.Seek(0, SeekOrigin.Begin);
				return (T)formatter.Deserialize(stream);
			}
		}

		#endregion Public Methods
	}
}
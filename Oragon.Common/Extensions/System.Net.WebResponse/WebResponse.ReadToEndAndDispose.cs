// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Net;
using System.Text;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>735E9495-5052-415E-8665-17CABEB8A1EB</id>
		/// <summary>
		///     A WebRequest extension method that gets the WebRequest response and read the response stream.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The response stream as a string, from the current position to the end.</returns>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
		public static string ReadToEndAndDispose(this WebResponse @this)
		{
			using (WebResponse response = @this)
			{
				using (Stream stream = response.GetResponseStream())
				{
					using (var reader = new StreamReader(stream, Encoding.Default))
					{
						return reader.ReadToEnd();
					}
				}
			}
		}

		#endregion Public Methods
	}
}
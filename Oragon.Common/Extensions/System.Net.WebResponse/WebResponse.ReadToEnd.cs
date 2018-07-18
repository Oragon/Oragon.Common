// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;
using System.Net;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>0E9A8B95-F6BB-439C-AB8F-8127D689D066</id>
		/// <summary>
		///     A WebResponse extension method that reads the response stream to the end.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The response stream as a string, from the current position to the end.</returns>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
		public static string ReadToEnd(this WebResponse @this)
		{
			using (Stream stream = @this.GetResponseStream())
			{
				using (var reader = new StreamReader(stream))
				{
					return reader.ReadToEnd();
				}
			}
		}

		#endregion Public Methods
	}
}
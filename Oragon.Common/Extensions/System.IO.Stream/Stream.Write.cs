// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>635D9852-FF20-4DF8-B511-4F3B08103596</id>
		/// <summary>
		///     A Stream extension method that converts the Stream to a byte array.
		/// </summary>
		/// <param name="this">The Stream to act on.</param>
		/// <returns>The Stream as a byte[].</returns>
		public static void Write(this Stream @this, string text, System.Text.Encoding encoding)
		{
			using (StreamWriter streamWriter = new StreamWriter(@this, encoding, 1024, true))
			{
				streamWriter.Write(text);
			}
		}

		#endregion Public Methods
	}
}
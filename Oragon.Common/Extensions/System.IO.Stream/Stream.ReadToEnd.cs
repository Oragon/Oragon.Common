// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>C7AD1296-FA71-4F70-B22D-75E99B7B1C80</id>
		/// <summary>
		///     A Stream extension method that reads a stream to the end.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     The rest of the stream as a string, from the current position to the end. If the current position is at the end of the stream, returns
		///     an empty string ("").
		/// </returns>
		public static string ReadToEnd(this Stream @this)
		{
			using (var sr = new StreamReader(@this))
			{
				return sr.ReadToEnd();
			}
		}

		/// <id>58212BE6-23B0-4701-B7AD-C9D9D3A92070</id>
		/// <summary>
		///     A Stream extension method that reads a stream to the end.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="position">The position to set in the stream.</param>
		/// <returns>
		///     The rest of the stream as a string, from the current position to the end. If the current position is at the end of the stream, returns
		///     an empty string ("").
		/// </returns>
		public static string ReadToEnd(this Stream @this, long position)
		{
			@this.Position = position;

			using (var sr = new StreamReader(@this))
			{
				return sr.ReadToEnd();
			}
		}

		#endregion Public Methods
	}
}
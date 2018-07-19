// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>6E1DAB07-346B-45C8-9FC5-93D4C6F841E7</id>
		/// <summary>
		///     A string extension method that converts the @this to a file information.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a FileInfo.</returns>
		/// <example>
		///     <code>
		///           var fileName = @"c:\test.txt";
		///
		///            var fileInfo = fileName.ToFileInfo();
		///     </code>
		/// </example>
		public static FileInfo ToFileInfo(this string @this)
		{
			return new FileInfo(@this);
		}

		#endregion Public Methods
	}
}
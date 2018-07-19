// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.IO;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>915624AF-6812-40A3-9C8C-72A6A49474A9</id>
		/// <summary>
		///     A DirectoryInfo extension method that creates a directory and all subdirectories.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		public static void CreateDirectory(this DirectoryInfo @this)
		{
			Directory.CreateDirectory(@this.FullName);
		}

		#endregion Public Methods
	}
}
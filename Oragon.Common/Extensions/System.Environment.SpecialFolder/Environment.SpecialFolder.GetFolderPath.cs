// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>EEA5D334-A3AD-4904-B44D-240A7E7B25E3</id>
		/// <summary>
		///     An Environment.SpecialFolder extension method that gets folder path.
		/// </summary>
		/// <param name="this">this.</param>
		/// <returns>The folder path.</returns>
		public static string GetFolderPath(this Environment.SpecialFolder @this)
		{
			return Environment.GetFolderPath(@this);
		}

		#endregion Public Methods
	}
}
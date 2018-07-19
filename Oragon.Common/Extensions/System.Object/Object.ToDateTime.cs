// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>0FC3B318-F73B-449E-81DB-21DEB5DF948A</id>
		/// <summary>
		///     An object extension method that converts the @this to a DateTime.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a DateTime.</returns>
		public static DateTime ToDateTime(this object @this)
		{
			return Convert.ToDateTime(@this);
		}

		#endregion Public Methods
	}
}
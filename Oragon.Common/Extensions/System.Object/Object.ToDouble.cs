// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>104274B2-6208-4C4A-B591-F57778FED433</id>
		/// <summary>
		///     An object extension method that converts the @this to a Double.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a Double.</returns>
		public static Double ToDouble(this object @this)
		{
			return Convert.ToDouble(@this);
		}

		#endregion Public Methods
	}
}
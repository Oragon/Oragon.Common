// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>D3FC5E54-2880-4A4D-AED7-485FF8270CFD</id>
		/// <summary>
		///     An object extension method that converts the @this to a nullable Double.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a Double?</returns>
		public static Double? ToNullableDouble(this object @this)
		{
			if (@this == null)
			{
				return null;
			}
			return Convert.ToDouble(@this);
		}

		#endregion Public Methods
	}
}
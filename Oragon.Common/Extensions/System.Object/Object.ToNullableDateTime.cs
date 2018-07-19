// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>61788FDF-4214-401B-80BD-6126E8B06B13</id>
		/// <summary>
		///     An object extension method that converts the @this to a nullable DateTime.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a DateTime?</returns>
		public static DateTime? ToNullableDateTime(this object @this)
		{
			if (@this == null)
			{
				return null;
			}
			return Convert.ToDateTime(@this);
		}

		#endregion Public Methods
	}
}
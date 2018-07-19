// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>31C8ECF8-F8C2-4B7C-BE31-AFB9EB133673</id>
		/// <summary>
		///     An object extension method that converts the @this to a nullable int.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as an int?</returns>
		public static int? ToNullableInt(this object @this)
		{
			if (@this == null)
			{
				return null;
			}
			return Convert.ToInt32(@this);
		}

		#endregion Public Methods
	}
}
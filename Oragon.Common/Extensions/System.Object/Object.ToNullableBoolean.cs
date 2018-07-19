// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>09EE7AD6-9904-4E9A-8F76-9F909673E62B</id>
		/// <summary>
		///     An object extension method that converts the @this to a nullable boolean.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a bool?</returns>
		public static bool? ToNullableBoolean(this object @this)
		{
			if (@this == null)
			{
				return null;
			}
			return Convert.ToBoolean(@this);
		}

		#endregion Public Methods
	}
}
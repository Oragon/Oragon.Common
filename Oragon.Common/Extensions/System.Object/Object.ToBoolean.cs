// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>9BCDD187-0372-4B95-819A-8B911FFEF8BC</id>
		/// <summary>
		///     An object extension method that converts the @this to a boolean.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a bool.</returns>
		public static bool ToBoolean(this object @this)
		{
			return Convert.ToBoolean(@this);
		}

		#endregion Public Methods
	}
}
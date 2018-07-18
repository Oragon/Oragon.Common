// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>86A7D93D-B244-4876-848E-3C2EF5E966B5</id>
		/// <summary>
		///     A DateTime extension method that query if '@this' is in the future.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if the value is in the future, false if not.</returns>
		public static bool IsFuture(this DateTime @this)
		{
			return @this > DateTime.Now;
		}

		#endregion Public Methods
	}
}
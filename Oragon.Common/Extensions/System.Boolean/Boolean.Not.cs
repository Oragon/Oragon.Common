﻿// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>51D65862-B68C-4DFB-9832-B0B1A01A4D94</id>
		/// <summary>
		///     A bool extension method that convert this object into a binary representation. If the value is true then 1 otherwise 0.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>1 if true, otherwise 0.</returns>
		public static bool Not(this bool @this)
		{
			return !@this;
		}

		#endregion Public Methods
	}
}
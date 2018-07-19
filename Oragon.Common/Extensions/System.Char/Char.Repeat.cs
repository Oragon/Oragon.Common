// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>FBC766DD-6FBB-4A55-B140-091A97E0DCD7</id>
		/// <summary>
		///     A char extension method that repeats a character a number of times.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="repeatCount">Number of repeats.</param>
		/// <returns>The repeated char.</returns>
		public static string Repeat(this char @this, int repeatCount)
		{
			return new String(@this, repeatCount);
		}

		#endregion Public Methods
	}
}
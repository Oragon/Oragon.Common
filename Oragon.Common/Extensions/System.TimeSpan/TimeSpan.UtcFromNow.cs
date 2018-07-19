// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>5F2B17FA-546A-42CC-B11E-5FE27C17657B</id>
		/// <summary>
		///     A TimeSpan extension method that add the specified TimeStamps to the current UTC (Coordinated Universal Time)
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The current UTC (Coordinated Universal Time) with the specified TimeStamp added to it.</returns>
		public static DateTime UtcFromNow(this TimeSpan @this)
		{
			return DateTime.UtcNow.Add(@this);
		}

		#endregion Public Methods
	}
}
// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>B6415F20-14E4-413F-A3F4-4C4E3E741B1A</id>
		/// <summary>
		///     A TimeSpan extension method that add the specified TimeStamp to the current DateTime.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The current DateTime with the specified TimeStamp added to it.</returns>
		public static DateTime FromNow(this TimeSpan @this)
		{
			return DateTime.Now.Add(@this);
		}

		#endregion Public Methods
	}
}
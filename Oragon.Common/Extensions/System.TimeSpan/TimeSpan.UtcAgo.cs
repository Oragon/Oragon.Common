// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>0797CB82-8D8B-49E5-B3D3-83BB87C8A625</id>
		/// <summary>
		///     A TimeSpan extension method that substract the specified TimeStamps to the current UTC (Coordinated Universal
		///     Time)
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The current UTC (Coordinated Universal Time) with the specified TimeStamp substracted to it.</returns>
		public static DateTime UtcAgo(this TimeSpan @this)
		{
			return DateTime.UtcNow.Subtract(@this);
		}

		#endregion Public Methods
	}
}
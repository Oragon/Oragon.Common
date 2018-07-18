// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>D0E14815-9D53-4371-9B74-E32D8DC49EB9</id>
		/// <summary>
		///     A TimeSpan extension method that substract the specified TimeStamp to the current DateTime.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The current DateTime with the specified TimeStamp substracted to it.</returns>
		public static DateTime Ago(this TimeSpan @this)
		{
			return DateTime.Now.Subtract(@this);
		}

		#endregion Public Methods
	}
}
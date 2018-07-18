// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>E26D9726-A2A6-402C-9ED1-234EF36615FC</id>
		/// <summary>
		///     A Random extension method that flip a coin toss.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true 50% of time, otherwise false.</returns>
		public static bool CoinToss(this Random @this)
		{
			return @this.Next(2) == 0;
		}

		#endregion Public Methods
	}
}
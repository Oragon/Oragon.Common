// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>069C0CCC-26F8-41C4-B3B5-78D8F0C0DC93</id>
		/// <summary>
		///     A T extension method that return the first not null occurence.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="this">The @this to act on.</param>
		/// <param name="values">A variable-length parameters list containing values.</param>
		/// <returns>The first not null occurence or null</returns>
		public static T Coalesce<T>(this T @this, params T[] values) where T : class
		{
			if (@this != null)
			{
				return @this;
			}
			foreach (T value in values)
			{
				if (value != null)
				{
					return value;
				}
			}
			return null;
		}

		#endregion Public Methods
	}
}
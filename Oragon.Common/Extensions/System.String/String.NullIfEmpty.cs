// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>52664028-724E-42FF-8972-6E5D5E1F7280</id>
		/// <summary>
		///     A string extension method that return null if the value is empty else the value.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>null if the value is empty, otherwise the value.</returns>
		public static string NullIfEmpty(this string @this)
		{
			return @this == "" ? null : @this;
		}

		#endregion Public Methods
	}
}
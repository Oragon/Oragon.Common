// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>B753CACE-44FB-4367-BB41-F7BC2450663F</id>
		/// <summary>
		///     A string extension method that queries if '@this' is null or is empty.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if '@this' is null or is empty, false if not.</returns>
		/// <example>
		///     <code>
		///         var test = "";
		///
		///         if(test.IsNullOrEmpty())
		///         {
		///             // ... Code ...
		///         }
		///     </code>
		/// </example>
		public static bool IsNullOrEmpty(this string @this)
		{
			return string.IsNullOrEmpty(@this);
		}

		#endregion Public Methods
	}
}
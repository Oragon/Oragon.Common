// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>2C413A45-B812-46EE-8397-1DCD3DDE719C</id>
		/// <summary>
		///     A string extension method that queries if '@this' is not (null or empty).
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if '@this' is not (null or empty), false if not.</returns>
		/// <example>
		///     <code>
		///         var test = "z";
		///
		///         if(test.IsNotNullOrEmpty())
		///         {
		///             // ... Code ...
		///         }
		///     </code>
		/// </example>
		public static bool IsNotNullOrEmpty(this string @this)
		{
			return !string.IsNullOrEmpty(@this);
		}

		#endregion Public Methods
	}
}
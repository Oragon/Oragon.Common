// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>6103DD9E-8C79-4FC1-B976-2621D584C5AB</id>
		/// <summary>
		///     An object extension method that query if '@this' is null.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>true if null, false if not.</returns>
		/// <example>
		///     <code>
		///         int[] list = null;
		///
		///         if(list.IsNull())
		///         {
		///             // Code
		///         }
		///     </code>
		/// </example>
		public static bool IsNull(this object @this)
		{
			return @this == null;
		}

		#endregion Public Methods
	}
}
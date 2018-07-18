// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Net;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>1D6BCCD1-193E-492E-98BF-C5B8BB9E40E2</id>
		/// <summary>
		///     A string extension method that converts the @this to a WebRequest.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a WebRequest.</returns>
		public static WebRequest ToWebRequest(this string @this)
		{
			return WebRequest.Create(@this);
		}

		#endregion Public Methods
	}
}
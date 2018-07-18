// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>EFACAC99-249F-4906-8CFB-2E86FF6619A1</id>
		/// <summary>
		///     An IDictionary extension method that converts the @this to a hashtable.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>@this as a Hashtable.</returns>
		public static Hashtable ToHashtable(this IDictionary @this)
		{
			return new Hashtable(@this);
		}

		#endregion Public Methods
	}
}
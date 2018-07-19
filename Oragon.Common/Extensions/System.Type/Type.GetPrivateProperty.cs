// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Reflection;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>6DE629CA-CAB7-48EE-889A-5A9F6508A98F</id>
		/// <summary>
		///     A Type extension method that gets private property.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="name">The name.</param>
		/// <returns>The private property.</returns>
		public static PropertyInfo GetPrivateProperty(this Type @this, string name)
		{
			return @this.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Instance);
		}

		#endregion Public Methods
	}
}
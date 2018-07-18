// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Reflection;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>A3A8B579-AF8A-4EF9-9C7E-DF16B2F98FEF</id>
		/// <summary>
		///     A Type extension method that gets public property.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="name">The name.</param>
		/// <returns>The public property.</returns>
		public static PropertyInfo GetPublicProperty(this Type @this, string name)
		{
			return @this.GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
		}

		#endregion Public Methods
	}
}
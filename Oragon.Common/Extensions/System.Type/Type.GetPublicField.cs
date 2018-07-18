// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Reflection;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>17BDAEA8-FB65-405C-A13D-B5B777E82397</id>
		/// <summary>
		///     A Type extension method that gets a public field.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="name">The name.</param>
		/// <returns>The public field.</returns>
		public static FieldInfo GetPublicField(this Type @this, string name)
		{
			return @this.GetField(name, BindingFlags.Public | BindingFlags.Instance);
		}

		#endregion Public Methods
	}
}
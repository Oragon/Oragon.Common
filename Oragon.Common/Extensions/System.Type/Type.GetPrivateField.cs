// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Reflection;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>08AD98FB-4106-40E3-8693-5CD2CC2F1996</id>
		/// <summary>
		///     A Type extension method that gets a private field.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="name">The name.</param>
		/// <returns>The private field.</returns>
		public static FieldInfo GetPrivateField(this Type @this, string name)
		{
			return @this.GetField(name, BindingFlags.NonPublic | BindingFlags.Instance);
		}

		#endregion Public Methods
	}
}
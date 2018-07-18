// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>3776A6DD-729E-4332-AC59-6D50A4B97CB4</id>
		/// <summary>
		///     A Type extension method that creates an instance of the type.
		/// </summary>
		/// <param name="type">The type to act on.</param>
		/// <param name="values">A variable-length parameters list containing arguments.</param>
		/// <returns>The new instance of the type.</returns>
		public static object CreateInstance(this Type type, params object[] values)
		{
			return Activator.CreateInstance(type, values);
		}

		/// <id>7B1FD313-DA3C-4033-9139-1ED2A6D99342</id>
		/// <summary>
		///     A Type extension method that creates an instance of the type.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="type">The type to act on.</param>
		/// <param name="values">A variable-length parameters list containing arguments.</param>
		/// <returns>The new instance&lt; t&gt;</returns>
		public static T CreateInstance<T>(this Type type, params object[] values)
		{
			return (T)Activator.CreateInstance(type, values);
		}

		#endregion Public Methods
	}
}
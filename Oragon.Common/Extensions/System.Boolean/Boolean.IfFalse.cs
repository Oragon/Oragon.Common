// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using FluentAssertions;
using System;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>F396C490-9448-475D-B3A9-FBAE682FDBB7</id>
		/// <summary>
		///     A bool extension method that execute an Action if the value is false.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <param name="action">The action to execute.</param>
		public static void IfFalse(this bool @this, Action action)
		{
			action.Should().NotBeNull();
			if (!@this)
			{
#pragma warning disable CC0031 // Check for null before calling a delegate
				action();
#pragma warning restore CC0031 // Check for null before calling a delegate
			}
		}

		#endregion Public Methods
	}
}
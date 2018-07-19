// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Globalization;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>883F4227-4DFE-4029-8831-99858EFDEB8F</id>
		/// <summary>
		///     Replaces the format item in a specified String with the text equivalent of the value of a corresponding Object instance in a specified array.
		/// </summary>
		/// <param name="this">A String containing zero or more format items.</param>
		/// <param name="values">An Object array containing zero or more objects to format.</param>
		/// <returns>
		///     A copy of format in which the format items have been replaced by the String equivalent of the corresponding instances of Object in args.
		/// </returns>
		public static string FormatWith(this string @this, params object[] values)
		{
			return String.Format(CultureInfo.InvariantCulture, @this, values);
		}

		#endregion Public Methods
	}
}
// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>FE31ABF6-0798-4D22-9379-C8D35A0A9B46</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as a Double. Additional
		///     columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     A double-precision floating-point number that is equivalent to the first column of the first row in the result set. If the value equal
		///     DBNull.Value, throw an exception.
		/// </returns>
		public static double ExecuteDouble(this DbCommand @this)
		{
			return Convert.ToDouble(@this.ExecuteScalar());
		}

		#endregion Public Methods
	}
}
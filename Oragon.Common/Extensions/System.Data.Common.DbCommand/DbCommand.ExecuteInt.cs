// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;
using System.Globalization;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>1A5D8B3E-C8CA-4AE7-9CDC-B51413319251</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as an Int. Additional
		///     columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     A 32-bit signed integer that is equivalent to the first column of the first row in the result set. If the value equal DBNull.Value,
		///     throw an exception.
		/// </returns>
		public static int ExecuteInt(this DbCommand @this)
		{
			return Convert.ToInt32(@this.ExecuteScalar(), CultureInfo.InvariantCulture);
		}

		#endregion Public Methods
	}
}
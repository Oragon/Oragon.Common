// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>4BCDD931-24A6-4728-A56A-B3D664A722E3</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as a nullable Double.
		///     Additional columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     A double-precision floating-point number that is equivalent to the first column of the first row in the result set. If the value equal
		///     DBNull.Value, return null.
		/// </returns>
		public static double? ExecuteNullableDouble(this DbCommand @this)
		{
			object result = @this.ExecuteScalar();
			if (result == DBNull.Value)
			{
				return null;
			}
			return Convert.ToDouble(result);
		}

		#endregion Public Methods
	}
}
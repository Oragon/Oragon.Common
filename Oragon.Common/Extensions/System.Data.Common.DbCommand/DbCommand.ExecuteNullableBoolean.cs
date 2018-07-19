// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;
using System.Globalization;

namespace Oragon.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>B14E9F9E-29AE-4D8D-BFC5-88DF82444494</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as a nullable Boolean.
		///     Additional columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     true or false, which reflects the value returned by invoking the IConvertible.ToBoolean method for the first column of the first row
		///     in the result set. If the value equal DBNull.Value, return null.
		/// </returns>
		public static bool? ExecuteNullableBoolean(this DbCommand @this)
		{
			object result = @this.ExecuteScalar();
			if (result == DBNull.Value)
			{
				return null;
			}
			return Convert.ToBoolean(result, CultureInfo.InvariantCulture);
		}

		#endregion Public Methods
	}
}
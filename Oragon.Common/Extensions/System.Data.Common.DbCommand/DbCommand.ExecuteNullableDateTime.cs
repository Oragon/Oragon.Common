// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>112FF174-72ED-40F4-8709-F77D06D24261</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as a nullable DateTime.
		///     Additional columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     The date and time equivalent of the value of the first column of the first row in the result set. If the value equal DBNull.Value,
		///     return null.
		/// </returns>
		public static DateTime? ExecuteNullableDateTime(this DbCommand @this)
		{
			object result = @this.ExecuteScalar();
			if (result == DBNull.Value)
			{
				return null;
			}
			return Convert.ToDateTime(result);
		}

		#endregion Public Methods
	}
}
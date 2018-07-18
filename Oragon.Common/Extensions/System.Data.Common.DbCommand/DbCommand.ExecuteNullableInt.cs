// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>C4E80BF0-146D-41A6-81FE-B502A96BCEC8</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as an nullable Int.
		///     Additional columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>
		///     A 32-bit signed integer that is equivalent to the first column of the first row in the result set. If the value equal DBNull.Value,
		///     return null.
		/// </returns>
		public static int? ExecuteNullableInt(this DbCommand @this)
		{
			object result = @this.ExecuteScalar();
			if (result == DBNull.Value)
			{
				return null;
			}
			return Convert.ToInt32(result);
		}

		#endregion Public Methods
	}
}
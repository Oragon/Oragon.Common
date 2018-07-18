// Copyright (c) 2013 Jonathan Magnan (http://zzzportal.com) All rights reserved. Licensed under MIT License (MIT) License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;

namespace Oragon.Architecture.Extensions
{
	public static partial class OragonExtensions
	{
		#region Public Methods

		/// <id>F6200813-2B43-462E-8511-CF763DE05EA7</id>
		/// <summary>
		///     Executes the query, and returns the first column of the first row in the result set returned by the query as a String. Additional
		///     columns or rows are ignored.
		/// </summary>
		/// <param name="this">The @this to act on.</param>
		/// <returns>The string representation of the first column of the first row in the result set. If value is DBNull, set to empty.</returns>
		public static string ExecuteString(this DbCommand @this)
		{
			object result = @this.ExecuteScalar();
			if (result == DBNull.Value)
			{
				return null;
			}
			return Convert.ToString(@this.ExecuteScalar());
		}

		#endregion Public Methods
	}
}